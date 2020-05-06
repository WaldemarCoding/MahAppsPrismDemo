using MahApps.Metro.PrismApp.Core;
using MahApps.Metro.PrismModule1.ViewModels;
using MahApps.Metro.PrismModule1.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace MahApps.Metro.PrismModule1
{
    public class Module1Module : IModule
    {
        private readonly IRegionManager _regionManager;

        public Module1Module(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.MenuRegion, typeof(Modul1Menu));
            _regionManager.RegisterViewWithRegion(RegionNames.FlyoutRegion, typeof(Module1Flyout));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
            containerRegistry.RegisterForNavigation<ViewB, ViewBViewModel>();
        }
    }
}