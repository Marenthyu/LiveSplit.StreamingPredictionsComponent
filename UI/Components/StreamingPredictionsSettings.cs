using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.Model;
using LiveSplit.Options;
using LiveSplit.Web;

namespace LiveSplit.UI.Components
{
    public partial class StreamingPredictionsSettings : UserControl
    {
        public string OAuthToken
        {
            get => _oAuthToken;
            set => _oAuthToken = value;
        }

        public string YesOptionName
        {
            get => _yesOptionName;
            set => _yesOptionName = value;
        }

        public string NoOptionName
        {
            get => _noOptionName;
            set => _noOptionName = value;
        }

        public string PredictionTitle
        {
            get => _predictionTitle;
            set => _predictionTitle = value;
        }

        public string CreateSplitName
        {
            get => _createSplitName;
            set => _createSplitName = value;
        }

        public string LockSplitName
        {
            get => _lockSplitName;
            set => _lockSplitName = value;
        }

        public string ResolveSplitName
        {
            get => _resolveSplitName;
            set => _resolveSplitName = value;
        }

        public int LockTime
        {
            get => _lockTime;
            set => _lockTime = value;
        }

        public int ResolveTime
        {
            get => _resolveTime;
            set => _resolveTime = value;
        }

        public int ResolveEndTime
        {
            get => _resolveEndTime;
            set => _resolveEndTime = value;
        }

        public bool CancelOnReset
        {
            get => _cancelOnReset;
            set => _cancelOnReset = value;
        }

        public bool CreateOnStart
        {
            get => _createOnStart;
            set => _createOnStart = value;
        }

        public bool CreateOnSplit
        {
            get => _createOnSplit;
            set => _createOnSplit = value;
        }


        public bool LockOnSplit
        {
            get => _lockOnSplit;
            set => _lockOnSplit = value;
        }

        public bool ResolveOnEndOfRun
        {
            get => _resolveOnEndOfRun;
            set => _resolveOnEndOfRun = value;
        }

        public bool ResolveOnEndOfRunReached
        {
            get => _resolveOnEndOfRunReached;
            set => _resolveOnEndOfRunReached = value;
        }

        public bool ResolveOnEndTimed
        {
            get => _resolveOnEndTimed;
            set => _resolveOnEndTimed = value;
        }

        public bool ResolveOnSplit
        {
            get => _resolveOnSplit;
            set => _resolveOnSplit = value;
        }

        public bool ResolveOnSplitReached
        {
            get => _resolveOnSplitReached;
            set => _resolveOnSplitReached = value;
        }

        public bool ResolveOnSplitTimed
        {
            get => _resolveOnSplitTimed;
            set => _resolveOnSplitTimed = value;
        }

        private const string Httpredirect = "<!DOCTYPE html>\n" + "<html lang=\"en\">\n" + "    <head>\n" +
                                            "        <meta charset=\"UTF-8\">\n" +
                                            "        <title>OAuth local redirection...</title>\n" + "    </head>\n" +
                                            "    <body>\n" + "        Hi, you shouldn't see this for long.\n" +
                                            "        <noscript>\n" +
                                            "            <h1>Please enable javascript! I need to redirect the oauth token to the application please :(</h1>\n" +
                                            "        </noscript>\n" + "        <script lang=\"javascript\">\n" +
                                            "                let req = new XMLHttpRequest();\n" +
                                            "                req.open('POST', '/', false);\n" +
                                            "                req.setRequestHeader('Content-Type', 'text');\n" +
                                            "                req.send(document.location.hash);\n" +
                                            "                console.log(\"response headers: \" + req.getAllResponseHeaders());\n" +
                                            "                console.log(\"I guess i can close now?\");\n" +
                                            "                window.close();\n" +
                                            "                document.body.innerText = req.response;\n" +
                                            "        </script>\n" +
                                            "    </body>\n" + "</html>\n";

        internal const string ClientID = "pa6ma4r90yurbtol0oxgpqnvrn2ei5";
        public static string userID = "";
        private string _oAuthToken;
        private string _yesOptionName;
        private string _noOptionName;
        private string _predictionTitle;
        private string _createSplitName;
        private string _lockSplitName;
        private string _resolveSplitName;
        private static string _userName = "";
        private int _lockTime = 600;
        private int _resolveTime = 60;
        private int _resolveEndTime = 60;
        private static bool _cancelOnReset = false;
        private static bool _createOnStart = true;
        private static bool _createOnSplit = false;
        private static bool _lockOnSplit = false;
        private static bool _resolveOnEndOfRun = true;
        private static bool _resolveOnEndOfRunReached = false;
        private static bool _resolveOnSplit = false;
        private static bool _resolveOnSplitReached = false;
        private static bool _resolveOnSplitTimed = false;
        private static bool _resolveOnEndTimed = false;

        private static HttpListener _listener;
        private static bool isListening = false;

        private static LiveSplitState State;


        public StreamingPredictionsSettings(LiveSplitState state)
        {
            InitializeComponent();

            OAuthToken = "";
            YesOptionName = "Yes";
            NoOptionName = "No";
            PredictionTitle = "Will this run PB?";
            CreateSplitName = "";
            LockSplitName = "";
            ResolveSplitName = "";
            LockTime = 600;
            ResolveTime = 60;
            CancelOnReset = false;
            ResolveOnEndOfRun = true;
            ResolveOnEndOfRunReached = false;
            CreateOnStart = true;
            CreateOnSplit = false;
            LockOnSplit = false;
            ResolveOnSplit = false;
            ResolveOnSplitReached = false;
            ResolveOnSplitTimed = false;
            ResolveOnEndTimed = false;
            //for (int i = 0; i < WaveOut.DeviceCount; ++i)
            //  cbOutputDevice.Items.Add(WaveOut.GetCapabilities(i));
            txtOAuthToken.DataBindings.Add("Text", this, "OAuthToken");
            textBox1.DataBindings.Add("Text", this, "YesOptionName");
            textBox2.DataBindings.Add("Text", this, "NoOptionName");
            textBox3.DataBindings.Add("Text", this, "PredictionTitle");
            textBox4.DataBindings.Add("Text", this, "CreateSplitName");
            textBox5.DataBindings.Add("Text", this, "LockSplitName");
            textBox6.DataBindings.Add("Text", this, "ResolveSplitName");
            numericUpDown1.DataBindings.Add("Value", this, "LockTime");
            numericUpDown2.DataBindings.Add("Value", this, "ResolveTime");
            numericUpDown3.DataBindings.Add("Value", this, "ResolveEndTime");
            checkBox1.DataBindings.Add("Checked", this, "CancelOnReset");
            //radioButton4.DataBindings.Add("Checked", this, "ResolveOnEndOfRun");
            //radioButton1.DataBindings.Add("Checked", this, "CreateOnStart", true, DataSourceUpdateMode.OnPropertyChanged);
            //radioButton2.DataBindings.Add("Checked", this, "CreateOnSplit", true, DataSourceUpdateMode.OnPropertyChanged);
            radioButton1.CheckedChanged += OnChange;
            radioButton2.CheckedChanged += OnChange;
            radioButton4.CheckedChanged += OnChange;
            radioButton5.CheckedChanged += OnChange;
            radioButton6.CheckedChanged += OnChange;
            radioButton7.CheckedChanged += OnChange;
            radioButton8.CheckedChanged += OnChange;
            radioButton9.CheckedChanged += OnChange;
            checkBox5.DataBindings.Add("Checked", this, "LockOnSplit");
            //radioButton5.DataBindings.Add("Checked", this, "ResolveOnSplit");
            //radioButton6.DataBindings.Add("Checked", this, "ResolveOnSplitTimed");
            State = state;
        }

        private void OnChange(object sender, EventArgs eventArgs)
        {
            if (sender == radioButton1)
            {
                CreateOnStart = ((RadioButton) sender).Checked;
            }
            else if (sender == radioButton2)
            {
                CreateOnSplit = ((RadioButton) sender).Checked;
            }
            else if (sender == radioButton4)
            {
                ResolveOnEndOfRun = ((RadioButton) sender).Checked;
            }
            else if (sender == radioButton5)
            {
                ResolveOnSplit = ((RadioButton) sender).Checked;
            }
            else if (sender == radioButton6)
            {
                ResolveOnSplitTimed = ((RadioButton) sender).Checked;
            }
            else if (sender == radioButton7)
            {
                ResolveOnEndTimed = ((RadioButton) sender).Checked;
            }
            else if (sender == radioButton8)
            {
                ResolveOnEndOfRunReached = ((RadioButton) sender).Checked;
            }
            else if (sender == radioButton9)
            {
                ResolveOnSplitReached = ((RadioButton) sender).Checked;
            }
        }

        public void SetSettings(XmlNode node)
        {
            var element = (XmlElement) node;

            OAuthToken = SettingsHelper.ParseString(element["OAuthToken"], "");
            YesOptionName = SettingsHelper.ParseString(element["YesOptionName"], "Yes");
            NoOptionName = SettingsHelper.ParseString(element["NoOptionName"], "No");
            PredictionTitle = SettingsHelper.ParseString(element["PredictionTitle"], "Will this run PB?");
            CreateSplitName = SettingsHelper.ParseString(element["CreateSplitName"], "");
            LockSplitName = SettingsHelper.ParseString(element["LockSplitName"], "");
            ResolveSplitName = SettingsHelper.ParseString(element["ResolveSplitName"], "");
            CancelOnReset = SettingsHelper.ParseBool(element["CancelOnReset"], false);
            ResolveOnEndOfRun = SettingsHelper.ParseBool(element["ResolveOnEndOfRun"], true);
            CreateOnStart = SettingsHelper.ParseBool(element["CreateOnStart"], true);
            CreateOnSplit = SettingsHelper.ParseBool(element["CreateOnSplit"], false);
            LockOnSplit = SettingsHelper.ParseBool(element["LockOnSplit"], false);
            ResolveOnSplit = SettingsHelper.ParseBool(element["ResolveOnSplit"], false);
            ResolveOnSplitTimed = SettingsHelper.ParseBool(element["ResolveOnSplitTimed"], false);
            ResolveOnEndTimed = SettingsHelper.ParseBool(element["ResolveOnEndTimed"], false);
            ResolveOnEndOfRunReached = SettingsHelper.ParseBool(element["ResolveOnEndOfRunReached"], false);
            ResolveOnSplitReached = SettingsHelper.ParseBool(element["ResolveOnSplitReached"], false);
            LockTime = SettingsHelper.ParseInt(element["LockTime"], 600);
            ResolveTime = SettingsHelper.ParseInt(element["ResolveTime"], 60);
            ResolveEndTime = SettingsHelper.ParseInt(element["ResolveEndTime"], 60);
            radioButton1.Checked = CreateOnStart;
            radioButton2.Checked = CreateOnSplit;
            radioButton3.Checked = !(CreateOnSplit || CreateOnStart);
            radioButton4.Checked = ResolveOnEndOfRun;
            radioButton5.Checked = ResolveOnSplit;
            radioButton6.Checked = ResolveOnSplitTimed;
            radioButton7.Checked = ResolveOnEndTimed;
            radioButton8.Checked = ResolveOnEndOfRunReached;
            radioButton9.Checked = ResolveOnSplitReached;
            doNotResolveRadioButton.Checked = !(ResolveOnEndOfRun || ResolveOnEndOfRunReached || ResolveOnSplit ||
                                                ResolveOnSplitTimed || ResolveOnEndTimed || ResolveOnSplitReached);
            validateToken().Wait();
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var parent = document.CreateElement("Settings");
            CreateSettingsNode(document, parent);
            return parent;
        }

        public int GetSettingsHashCode()
        {
            return CreateSettingsNode(null, null);
        }

        private int CreateSettingsNode(XmlDocument document, XmlElement parent)
        {
            return SettingsHelper.CreateSetting(document, parent, "Version", "2.0") ^
                   SettingsHelper.CreateSetting(document, parent, "OAuthToken", OAuthToken) ^
                   SettingsHelper.CreateSetting(document, parent, "YesOptionName", YesOptionName) ^
                   SettingsHelper.CreateSetting(document, parent, "NoOptionName", NoOptionName) ^
                   SettingsHelper.CreateSetting(document, parent, "PredictionTitle", PredictionTitle) ^
                   SettingsHelper.CreateSetting(document, parent, "CreateSplitName", CreateSplitName) ^
                   SettingsHelper.CreateSetting(document, parent, "LockSplitName", LockSplitName) ^
                   SettingsHelper.CreateSetting(document, parent, "ResolveSplitName", ResolveSplitName) ^
                   SettingsHelper.CreateSetting(document, parent, "LockTime", LockTime) ^
                   SettingsHelper.CreateSetting(document, parent, "ResolveTime", ResolveTime) ^
                   SettingsHelper.CreateSetting(document, parent, "ResolveEndTime", ResolveEndTime) ^
                   SettingsHelper.CreateSetting(document, parent, "CancelOnReset", CancelOnReset) ^
                   SettingsHelper.CreateSetting(document, parent, "CreateOnStart", CreateOnStart) ^
                   SettingsHelper.CreateSetting(document, parent, "CreateOnSplit", CreateOnSplit) ^
                   SettingsHelper.CreateSetting(document, parent, "LockOnSplit", LockOnSplit) ^
                   SettingsHelper.CreateSetting(document, parent, "ResolveOnEndOfRun", ResolveOnEndOfRun) ^
                   SettingsHelper.CreateSetting(document, parent, "ResolveOnEndOfRunReached",
                       ResolveOnEndOfRunReached) ^
                   SettingsHelper.CreateSetting(document, parent, "ResolveOnSplitReached",
                       ResolveOnSplitReached) ^
                   SettingsHelper.CreateSetting(document, parent, "ResolveOnSplit", ResolveOnSplit) ^
                   SettingsHelper.CreateSetting(document, parent, "ResolveOnSplitTimed", ResolveOnSplitTimed) ^
                   SettingsHelper.CreateSetting(document, parent, "ResolveOnEndTimed", ResolveOnEndTimed);
        }

#pragma warning disable 1998
        internal async Task validateToken()
#pragma warning restore 1998
        {
            Log.Info("Validating token");
            try
            {
                Log.Info("Sending request");
                WebRequest r = WebRequest.Create("https://id.twitch.tv/oauth2/validate");
                r.Headers.Add("Authorization", "OAuth " + OAuthToken);
                Log.Info(string.Join(", ", r.Headers));
                WebResponse response;
                try
                {
                    response = r.GetResponse();
                }
                catch (WebException we)
                {
                    Log.Info("Error Status: " + ((HttpWebResponse) we.Response).StatusCode.ToString());
                    if (we.Status.Equals(WebExceptionStatus.ProtocolError) &&
                        ((HttpWebResponse) we.Response).StatusCode == HttpStatusCode.Unauthorized)
                    {
                        response = we.Response;
                    }
                    else
                    {
                        throw we;
                    }
                }

                StreamReader streamReader = new StreamReader(response.GetResponseStream());
                var responseContent = streamReader.ReadToEnd();
                Log.Info("Got response: " + responseContent);
                var j = JSON.FromString(responseContent);
                Log.Info("Parsed json");
                if (((HttpWebResponse) response).StatusCode == HttpStatusCode.OK)
                {
                    Log.Info("Success!");
                    userID = j["user_id"];
                    int expiresIn = j["expires_in"];
                    if (expiresIn < 24 * 60 * 60) // token expires within 24 hours
                    {
                        Log.Warning("Old Token! Request new token from user pls...");
                        AskForNewToken();
                    }

                    WebRequest r2 = WebRequest.Create("https://api.twitch.tv/helix/users");
                    r2.Headers.Add("Authorization", "Bearer " + OAuthToken);
                    r2.Headers.Add("Client-ID", ClientID);
                    var userResponse = r2.GetResponse();
                    StreamReader sr2 = new StreamReader(userResponse.GetResponseStream());
                    var userResponseContent = sr2.ReadToEnd();
                    var userJ = JSON.FromString(userResponseContent);
                    _userName = userJ["data"][0]["login"];
                    Log.Info("Got username: " + _userName);
                }
                else
                {
                    Log.Warning("Invalid Token! Request new token from user pls...");
                    AskForNewToken();
                }
            }
            catch (WebException ex)
            {
                Log.Error(ex);
                using (var stream = ex.Response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    Log.Error(reader.ReadToEnd());
                }
            }
        }

        private void AskForNewToken()
        {
            DialogResult dialogResult =
                MessageBox.Show(
                    "Your Predictions Integration Token is invalid or will expire soon.\nDo you want to save a new one now?",
                    "Streaming Prediction Integration", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                getTokenBtn_Click(null, null);
            }
        }

        private void getTokenBtn_Click(object sender, EventArgs e)
        {
            Process.Start(
                "https://id.twitch.tv/oauth2/authorize?client_id=" + ClientID +
                "&redirect_uri=http%3A%2F%2Flocalhost%3A17863" +
                "&response_type=token" +
                "&scope=channel:manage:predictions");
            if (!isListening)
            {
                Task.Factory.StartNew(async () =>
                {
                    isListening = true;
                    _listener?.Abort();
                    _listener = new HttpListener();
                    _listener.Prefixes.Add("http://localhost:17863/");
                    _listener.Start();
                    while (_listener.IsListening)
                    {
                        var context = await _listener.GetContextAsync();
                        var request = context.Request;
                        var response = context.Response;

                        if (request.HttpMethod == "POST")
                        {
                            string text;
                            using (var reader = new StreamReader(request.InputStream,
                                request.ContentEncoding))
                            {
                                text = await reader.ReadToEndAsync();
                            }

                            var buffer = Encoding.UTF8.GetBytes("Thank you. Close this now.");
                            response.ContentLength64 = buffer.Length;
                            var output = response.OutputStream;
                            await output.WriteAsync(buffer, 0, buffer.Length);
                            output.Close();
                            _listener.Close();
                            isListening = false;
                            var decoded = HttpUtility.UrlDecode(text);
                            var parts = decoded.Split('&');
                            foreach (var part in parts)
                            {
                                var keyvalueparts = part.Split('=');
                                var key = keyvalueparts[0].Replace("#", "");
                                var value = keyvalueparts[1];
                                if (!key.Equals("access_token")) continue;
                                // Validate token
                                OAuthToken = value;
                                txtOAuthToken.Text = value;
                                await validateToken();
                                //MessageBox.Show("Your token has been updated. Please remember to save your layout.", "Streaming Prediction Integration", MessageBoxButtons.OK);
                                State.Layout.HasChanged = true;
                            }
                        }
                        else
                        {
                            var buffer = Encoding.UTF8.GetBytes(Httpredirect);
                            response.ContentLength64 = buffer.Length;
                            var output = response.OutputStream;
                            await output.WriteAsync(buffer, 0, buffer.Length);
                            output.Close();
                        }
                    }
                }).Wait();
            }
        }
    }
}