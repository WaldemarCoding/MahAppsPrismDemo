using MahApps.Metro.Controls;
using Prism.Mvvm;

namespace MahApps.Metro.PrismApp.Core.Base
{
    public class FlyoutViewModelBase : BindableBase
    {
        public FlyoutViewModelBase()
        {
            Theme = FlyoutTheme.Accent;
        }

        private Position _position;
        public Position Position
        {
            get { return _position; }
            set { SetProperty(ref _position, value); }
        }

        private bool _isOpen;
        public bool IsOpen
        {
            get { return _isOpen; }
            set { SetProperty(ref _isOpen, value); }
        }

        private string _header;
        public string Header
        {
            get { return _header; }
            set { SetProperty(ref _header, value); }
        }

        private FlyoutTheme _theme;
        public FlyoutTheme Theme
        {
            get { return _theme; }
            set { SetProperty(ref _theme, value); }
        }

        private string _tag;
        public string Tag
        {
            get { return _tag; }
            set { SetProperty(ref _tag, value); }
        }
    }
}
