using System.Linq;
using MahApps.Metro.PrismApp.Core;
using MahApps.Metro.PrismApp.Core.Base;
using Prism.Commands;
using Prism.Events;
using Prism.Regions;

namespace MahApps.Metro.PrismModule2.ViewModels
{
    public class ViewCViewModel : ViewModelBase
    {
        private readonly IEventAggregator _eventAggregator;
        private readonly IRegionManager _regionManager;
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewCViewModel(IEventAggregator eventAggregator, IRegionManager regionManager)
        {
            Title = "ViewC - M2";
            Message = "View C from Module 2";
            _eventAggregator = eventAggregator;
            _regionManager = regionManager;
        }

        private DelegateCommand<string> _toggleFlyoutCommand;
        public DelegateCommand<string> ToggleFlyoutCommand => _toggleFlyoutCommand ?? (_toggleFlyoutCommand = new DelegateCommand<string>(ExecuteToggleFlyoutCommand));

        private void ExecuteToggleFlyoutCommand(string tag)
        {
            _eventAggregator.GetEvent<ToggleFlyoutEvent>().Publish(new ToggleFlyoutEventArgs { FlyoutTag = tag });
        }

        private DelegateCommand _removeMenuCommand;
        public DelegateCommand RemoveMenuCommand => _removeMenuCommand ?? (_removeMenuCommand = new DelegateCommand(ExecuteRemoveMenuCommand));

        void ExecuteRemoveMenuCommand()
        {
            var rmR = _regionManager.Regions[RegionNames.MenuRegion];
            var view = rmR.ActiveViews.FirstOrDefault<dynamic>(v => v.DependencyObjectType.Name == "Module2Menu");

            if (view != null)
            {
                rmR.Remove(view);
            }
        }
    }
}
