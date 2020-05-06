using MahApps.Metro.Controls;
using MahApps.Metro.PrismApp.Core.Base;

namespace MahApps.Metro.PrismModule2.ViewModels
{
    public class Module2FlyoutViewModel : FlyoutViewModelBase
    {
        public Module2FlyoutViewModel()
        {
            Tag = "Module2Flyout";
            Header = "Module 2 Flyout";
            Position = Position.Right;
        }
    }
}
