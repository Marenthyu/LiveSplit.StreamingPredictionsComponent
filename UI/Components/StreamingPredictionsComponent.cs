using LiveSplit.Model;
using LiveSplit.Options;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.Web;

namespace LiveSplit.UI.Components
{
    public class StreamingPredictionsComponent : LogicComponent, IDeactivatableComponent
    {
        public override string ComponentName => "Streaming Predictions Integration";

        public bool Activated { get; set; }

        private LiveSplitState State { get; set; }
        private static StreamingPredictionsSettings Settings { get; set; }
        private bool hasClosedPrediction = false;

        private string currentPredictionID = "";
        private string yesID = "";
        private string noID = "";

        public StreamingPredictionsComponent(LiveSplitState state)
        {
            Activated = true;

            State = state;
            Settings = new StreamingPredictionsSettings(state);

            //Settings.validateToken().Wait();
            //Log.Info("Username from settings object: " + WaifuTCGSettings.userName);

            State.OnStart += State_OnStart;
            State.OnSplit += State_OnSplit;
            State.OnReset += State_OnReset;
        }


        public override void Dispose()
        {
            State.OnStart -= State_OnStart;
            State.OnSplit -= State_OnSplit;
            State.OnReset -= State_OnReset;
        }

        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height,
            LayoutMode mode)
        {
        }

        public override Control GetSettingsControl(LayoutMode mode)
        {
            return Settings;
        }

        public override XmlNode GetSettings(XmlDocument document)
        {
            return Settings.GetSettings(document);
        }

        public override void SetSettings(XmlNode settings)
        {
            Log.Info("Settings set!");
            //var oldToken = Settings.OAuthToken;
            Settings.SetSettings(settings);
        }


        private void State_OnStart(object sender, EventArgs e)
        {
            // we start!
            //PlaySound(Settings.StartTimer, Settings.StartTimerVolume);
            try
            {
                if (Settings.CreateOnStart)
                {
					_ = StartNewPredictionAsync();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex);
            }
        }

        private void State_OnSplit(object sender, EventArgs e)
        {
            try
            {
                if (State.CurrentPhase == TimerPhase.Ended)
                {
                    if (Settings.ResolveOnEndOfRun)
                    {
                        // we done.
                        // Logic for this if statement from LiveSplit.Sound https://github.com/LiveSplit/LiveSplit.Sound/blob/master/UI/Components/SoundComponent.cs#L79
                        bool isPB = State.Run.Last().PersonalBestSplitTime[State.CurrentTimingMethod] == null ||
                                    State.Run.Last().SplitTime[State.CurrentTimingMethod] <
                                    State.Run.Last().PersonalBestSplitTime[State.CurrentTimingMethod];
						_ = ResolveCurrentPredictionAsync(isPB);
                    }
                    else if (Settings.ResolveOnEndTimed)
                    {
                        var wasFastEnough = State.CurrentTime[State.CurrentTimingMethod].Value <
                                            TimeSpan.FromSeconds(Settings.ResolveEndTime);
						_ = ResolveCurrentPredictionAsync(wasFastEnough);
                    }
                    else if (Settings.ResolveOnAmountEndOfRun && (Settings.ResolveOnGoldSplits ||
                                                                  Settings.ResolveOnGoodSplits ||
                                                                  Settings.ResolveOnBadSplits))
                    {
                        var segments = State.Run;
                        ResolveForCount(segments);
                    }
                }
                else
                {
                    if (Settings.CreateOnSplit && State.CurrentSplit.Name.Contains(Settings.CreateSplitName))
                    {
						_ = StartNewPredictionAsync();
                    }
                    else
                    {
                        if (Settings.LockOnSplit && State.CurrentSplit.Name.Contains(Settings.LockSplitName))
                        {
							_ = LockCurrentPredictionAsync();
                        }
                    }

                    if (State.CurrentSplit.Name.Contains(Settings.ResolveSplitName))
                    {
                        if (Settings.ResolveOnSplitReached)
                        {
							_ = ResolveCurrentPredictionAsync(true);
                        }
                        else if (Settings.ResolveOnSplit)
                        {
                            var splitIndex = State.CurrentSplitIndex - 1;
                            var timeDifference = State.Run[splitIndex].SplitTime[State.CurrentTimingMethod] -
                                                 State.Run[splitIndex].Comparisons[State.CurrentComparison][
                                                     State.CurrentTimingMethod];
                            var ahead = timeDifference < TimeSpan.Zero;
							_ = ResolveCurrentPredictionAsync(ahead);
                        }
                        else if (Settings.ResolveOnSplitTimed)
                        {
                            var wasFastEnough = State.CurrentTime[State.CurrentTimingMethod].Value <
                                                TimeSpan.FromSeconds(Settings.ResolveTime);
							_ = ResolveCurrentPredictionAsync(wasFastEnough);
                        }
                    }

                    if (Settings.ResolveOnAmountStartOfSplit &&
                        State.CurrentSplit.Name.Contains(Settings.ResolveOnAmountSplitName))
                    {
                        ResolveForCount(State.Run);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex);
            }
        }

        private void ResolveForCount(IRun run)
        {
            int gold = 0, good = 0, bad = 0;
            foreach (ISegment segment in run)
            {
                var hasTime = segment.SplitTime[State.CurrentTimingMethod] != null;
                if (!hasTime)
                {
                    continue;
                }
                
                var wasGold = LiveSplitStateHelper.CheckBestSegment(State, run.IndexOf(segment), State.CurrentTimingMethod);
                var delta = LiveSplitStateHelper.GetPreviousSegmentDelta(State, run.IndexOf(segment),
                    State.CurrentComparison, State.CurrentTimingMethod);
                if (wasGold)
                {
                    gold++;
                }

                if (delta < TimeSpan.Zero)
                {
                    good++;
                }
                else
                {
                    bad++;
                }
            }

            if (Settings.ResolveOnGoldSplits)
            {
				_ = ResolveCurrentPredictionAsync(gold >= Settings.ResolveOnAmount);
            }
            else if (Settings.ResolveOnGoodSplits)
            {
				_ = ResolveCurrentPredictionAsync(good >= Settings.ResolveOnAmount);
            }
            else if (Settings.ResolveOnBadSplits)
            {
				_ = ResolveCurrentPredictionAsync(bad >= Settings.ResolveOnAmount);
            }
        }

        private void State_OnReset(object sender, TimerPhase e)
        {
            try
            {
                if (e == TimerPhase.Paused ||
                    e == TimerPhase.Running) // Only do stuff to the prediction if we actually aborted a run
                {
                    if (Settings.CancelOnReset)
                    {
						_ = CancelCurrentPredictionAsync();
                    }
                    else
                    {
						_ = ResolveCurrentPredictionAsync(false);
                    }

                    hasClosedPrediction = false;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex);
            }
        }

        public int GetSettingsHashCode() => Settings.GetSettingsHashCode();

        private async Task<dynamic> StartNewPredictionAsync()
        {
            var id = StreamingPredictionsSettings.userID;
            var j = await DoWebRequestAsync("https://api.twitch.tv/helix/predictions", "POST",
                "{\"broadcaster_id\":\"" + id +
                "\", \"title\":\"" + JSON.Escape(Settings.PredictionTitle) + "\", \"prediction_window\":" + Settings.LockTime +
                ", \"outcomes\": [{\"title\":\"" + JSON.Escape(Settings.YesOptionName) + "\"}, {\"title\":\"" +
                JSON.Escape(Settings.NoOptionName) + "\"}]}");
            currentPredictionID = j["data"][0]["id"];
            foreach (var outcome in j["data"][0]["outcomes"])
            {
                if (outcome["title"].Equals(Settings.YesOptionName))
                {
                    yesID = outcome["id"];
                }
                else
                {
                    noID = outcome["id"];
                }
            }

            hasClosedPrediction = false;

            return j;
        }

        private async Task<dynamic> ResolveCurrentPredictionAsync(bool success)
        {
            if (!hasClosedPrediction)
            {
                hasClosedPrediction = true;
                return await DoWebRequestAsync("https://api.twitch.tv/helix/predictions", "PATCH",
                    "{\"broadcaster_id\":\"" + StreamingPredictionsSettings.userID +
                    "\", \"id\":\"" + currentPredictionID + "\", \"status\":\"RESOLVED\", \"winning_outcome_id\": \"" +
                    (success ? yesID : noID) + "\"}");
            }
            else
            {
                return null;
            }
        }

        private async Task<dynamic> CancelCurrentPredictionAsync()
        {
            if (!hasClosedPrediction)
            {
                hasClosedPrediction = true;
                return await DoWebRequestAsync("https://api.twitch.tv/helix/predictions", "PATCH",
                    "{\"broadcaster_id\":\"" + StreamingPredictionsSettings.userID +
                    "\", \"id\":\"" + currentPredictionID + "\", \"status\":\"CANCELED\"}");
            }
            else
            {
                return null;
            }
        }

        private async Task<dynamic> LockCurrentPredictionAsync()
        {
            return await DoWebRequestAsync("https://api.twitch.tv/helix/predictions", "PATCH",
                "{\"broadcaster_id\":\"" + StreamingPredictionsSettings.userID +
                "\", \"id\":\"" + currentPredictionID + "\", \"status\":\"LOCKED\"}");
        }

        private async Task<dynamic> DoWebRequestAsync(string url, string method, string data = null)
        {
            WebRequest r2 = WebRequest.Create(url);
            r2.Headers.Add("Authorization", "Bearer " + Settings.OAuthToken);
            r2.Headers.Add("Client-ID", StreamingPredictionsSettings.ClientID);
            r2.Method = method;

            if (data != null)
            {
                r2.ContentType = "application/json";
                UTF8Encoding encoding = new UTF8Encoding();
                byte[] bytes = encoding.GetBytes(data);

                r2.ContentLength = bytes.Length;

                using (Stream requestStream = r2.GetRequestStream())
                {
                    await requestStream.WriteAsync(bytes, 0, bytes.Length);
                }
            }

            var requestResponse = await r2.GetResponseAsync();
            StreamReader sr2 = new StreamReader(requestResponse.GetResponseStream());
            var requestResponseData = sr2.ReadToEnd();
            Log.Info("Got web Request response: " + requestResponseData);
            return JSON.FromString(requestResponseData);
        }
    }
}