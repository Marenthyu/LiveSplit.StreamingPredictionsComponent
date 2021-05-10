using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;

[assembly: ComponentFactory(typeof(StreamingPredictionsFactory))]

namespace LiveSplit.UI.Components
{
    public class StreamingPredictionsFactory : IComponentFactory
    {
        public string ComponentName => "Streaming Predictions Integration";

        public string Description => "Opens Twitch Predictions for your runs";

        public ComponentCategory Category => ComponentCategory.Other;

        public IComponent Create(LiveSplitState state) => new StreamingPredictionsComponent(state);

        public string UpdateName => ComponentName;

        public string XMLURL => "";

        public string UpdateURL => "";

        public Version Version => Version.Parse("1.0.0");
    }
}
