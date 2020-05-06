using MahApps.Metro.Controls;
using MahApps.Metro.PrismApp.ViewModels;

namespace MahApps.Metro.PrismApp.Views
{
    /// <summary>
    /// Interaction logic for FlyoutTop.xaml
    /// </summary>
    public partial class FlyoutTop
    {
        public FlyoutTop()
        {
            InitializeComponent();
            DataContext = new FlyoutDefaultViewModel("Top", Position.Top, nameof(FlyoutTop));
        }
    }
}
