using MahApps.Metro.Controls;
using MahApps.Metro.PrismApp.Core.Base;

namespace MahApps.Metro.PrismModule1.ViewModels
{
    public class Module1FlyoutViewModel : FlyoutViewModelBase
    {
        public Module1FlyoutViewModel()
        {
            Tag = "Module1Flyout";
            Header = "Module 1 Flyout";
            Position = Position.Right;
        }
    }
}
