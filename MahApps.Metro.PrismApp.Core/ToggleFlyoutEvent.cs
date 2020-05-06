using Prism.Events;

namespace MahApps.Metro.PrismApp.Core
{
    public class ToggleFlyoutEventArgs
    {
        public string FlyoutTag { get; set; }
    }

    public class ToggleFlyoutEvent : PubSubEvent<ToggleFlyoutEventArgs>
    {
    }
}
