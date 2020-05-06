using System.Windows;
using MahApps.Metro.Controls;
using MahApps.Metro.PrismModule1;
using MahApps.Metro.PrismModule2;
using MahApps.Metro.PrismApp.Core;
using MahApps.Metro.PrismApp.Core.RegionAdapters;
using MahApps.Metro.PrismApp.Views;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace MahApps.Metro.PrismApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IApplicationCommands, ApplicationCommands>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<Module1Module>();
            moduleCatalog.AddModule<Module2Module>();
        }

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            // Custom Adapters
            regionAdapterMappings.RegisterMapping(typeof(HamburgerMenu), Container.Resolve<MahAppsHamburgerMenuRegionAdapter>());
            regionAdapterMappings.RegisterMapping(typeof(FlyoutsControl), Container.Resolve<MahAppsFlyoutsControlRegionAdapter>());
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            var rm = Container.Resolve<IRegionManager>();
            rm.RegisterViewWithRegion(RegionNames.FlyoutRegion, typeof(FlyoutTop));
            rm.RegisterViewWithRegion(RegionNames.FlyoutRegion, typeof(FlyoutBottom));
            rm.RegisterViewWithRegion(RegionNames.FlyoutRegion, typeof(FlyoutRight));
            rm.RegisterViewWithRegion(RegionNames.FlyoutRegion, typeof(FlyoutLeft));
        }
    }
}
