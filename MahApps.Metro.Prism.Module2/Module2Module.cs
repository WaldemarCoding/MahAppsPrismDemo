using MahApps.Metro.PrismApp.Core;
using MahApps.Metro.PrismModule2.ViewModels;
using MahApps.Metro.PrismModule2.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace MahApps.Metro.PrismModule2
{
    public class Module2Module : IModule
    {
        private readonly IRegionManager _regionManager;

        public Module2Module(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.MenuRegion, typeof(Module2Menu));
            _regionManager.RegisterViewWithRegion(RegionNames.FlyoutRegion, typeof(Module2Flyout));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewC, ViewCViewModel>();
        }
    }
}