using MahApps.Metro.Controls;
using MahApps.Metro.PrismApp.Core.Base;

namespace MahApps.Metro.PrismApp.ViewModels
{
    public class FlyoutDefaultViewModel : FlyoutViewModelBase
    {
        public FlyoutDefaultViewModel(string header, Position position, string tag, FlyoutTheme theme = FlyoutTheme.Accent, bool isOpen = false)
        {
            Header = header;
            Position = position;
            Tag = tag;
            Theme = theme;
            IsOpen = isOpen;
        }
    }
}
