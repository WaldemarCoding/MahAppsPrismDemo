using System;
using MahApps.Metro.PrismApp.Core;
using MahApps.Metro.PrismApp.Core.Base;
using Prism.Commands;
using Prism.Events;
using Prism.Regions;

namespace MahApps.Metro.PrismApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IEventAggregator _eventAggregator;

        public MainWindowViewModel(IRegionManager regionManager, IApplicationCommands applicationCommands, IEventAggregator eventAggregator)
        {
            Title = "Prism MahApps.Metro Demo";
            _regionManager = regionManager;
            _eventAggregator = eventAggregator;
            applicationCommands.NavigateCommand.RegisterCommand(NavigateCommand);
        }
        
        private DelegateCommand<string> _navigateCommand;
        public DelegateCommand<string> NavigateCommand => _navigateCommand ?? (_navigateCommand = new DelegateCommand<string>(ExecuteNavigateCommand));

        private void ExecuteNavigateCommand(string navigationPath)
        {
            if (string.IsNullOrEmpty(navigationPath))
            {
                throw new ArgumentNullException(nameof(navigationPath));
            }
            _regionManager.RequestNavigate(RegionNames.ContentRegion, navigationPath);
            _regionManager.RequestNavigate(RegionNames.TabRegion, navigationPath);
        }

        private DelegateCommand<string> _toggleFlyoutCommand;
        public DelegateCommand<string> ToggleFlyoutCommand => _toggleFlyoutCommand ?? (_toggleFlyoutCommand = new DelegateCommand<string>(ExecuteToggleFlyoutCommand));

        private void ExecuteToggleFlyoutCommand(string name)
        {
            _eventAggregator.GetEvent<ToggleFlyoutEvent>().Publish(new ToggleFlyoutEventArgs { FlyoutTag = name });
        }
    }
}
