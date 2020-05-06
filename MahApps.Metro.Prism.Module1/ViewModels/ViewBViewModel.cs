using MahApps.Metro.PrismApp.Core;
using MahApps.Metro.PrismApp.Core.Base;
using Prism.Commands;
using Prism.Events;

namespace MahApps.Metro.PrismModule1.ViewModels
{
    public class ViewBViewModel : ViewModelBase
    {
        private readonly IEventAggregator _eventAggregator;
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewBViewModel(IEventAggregator eventAggregator)
        {
            Title = "ViewB - M1";
            Message = "View B from Module 1";
            _eventAggregator = eventAggregator;
        }

        private DelegateCommand<string> _toggleFlyoutCommand;
        public DelegateCommand<string> ToggleFlyoutCommand => _toggleFlyoutCommand ?? (_toggleFlyoutCommand = new DelegateCommand<string>(ExecuteToggleFlyoutCommand));

        private void ExecuteToggleFlyoutCommand(string tag)
        {
            _eventAggregator.GetEvent<ToggleFlyoutEvent>().Publish(new ToggleFlyoutEventArgs { FlyoutTag = tag });
        }
    }
}
