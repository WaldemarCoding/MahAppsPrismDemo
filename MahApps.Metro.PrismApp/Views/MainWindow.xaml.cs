using System.Linq;
using System.Windows;
using MahApps.Metro.Controls;
using MahApps.Metro.PrismApp.Core;
using Prism.Events;
using Prism.Regions;

namespace MahApps.Metro.PrismApp.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private readonly IApplicationCommands _applicationCommands;

        public MainWindow(IApplicationCommands applicationCommands,
            IRegionManager regionManager,
            IEventAggregator eventAggregator)
        {
            _applicationCommands = applicationCommands;
            eventAggregator.GetEvent<ToggleFlyoutEvent>().Subscribe(ToggleFlyout);
            InitializeComponent();

            // So we can display View from Module in ContentControl
            RegionManager.SetRegionName(HamburgerMenuContent, RegionNames.ContentRegion);
            RegionManager.SetRegionManager(HamburgerMenuContent, regionManager);

            // So we can display View from Module as TabItem
            RegionManager.SetRegionName(HamburgerMenuTabContent, RegionNames.TabRegion);
            RegionManager.SetRegionManager(HamburgerMenuTabContent, regionManager);
        }

        private void ToggleFlyout(ToggleFlyoutEventArgs args)
        {
            var list = FlyoutsControl.Items.Cast<Flyout>().ToList();
            var flyout = list.FirstOrDefault(f => f.Tag.ToString() == args.FlyoutTag);
            if (flyout != null)
            {
                flyout.IsOpen = !flyout.IsOpen;
            }
        }

        private void HamburgerMenuControl_OnItemClick(object sender, ItemClickEventArgs args)
        {
            if (((HamburgerMenu)sender).SelectedItem is HamburgerMenuItem child)
            {
                if (child.CommandParameter is string path)
                {
                    _applicationCommands.NavigateCommand.Execute(path);
                }
            }
        }

        private void HamburgerMenuControl_OnLoaded(object sender, RoutedEventArgs e)
        {
            if (((HamburgerMenu)sender).SelectedItem is IMenuRootItem root)
            {
                _applicationCommands.NavigateCommand.Execute(root.DefaultNavigationPath);
            }
        }
    }
}
