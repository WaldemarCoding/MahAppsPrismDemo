using MahApps.Metro.Controls;
using MahApps.Metro.PrismApp.ViewModels;

namespace MahApps.Metro.PrismApp.Views
{
    /// <summary>
    /// Interaction logic for FlyoutLeft.xaml
    /// </summary>
    public partial class FlyoutLeft
    {
        public FlyoutLeft()
        {
            InitializeComponent();
            DataContext = new FlyoutDefaultViewModel("Left", Position.Left, nameof(FlyoutLeft));

        }
    }
}
