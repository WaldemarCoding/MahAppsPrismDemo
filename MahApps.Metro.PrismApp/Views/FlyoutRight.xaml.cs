using MahApps.Metro.Controls;
using MahApps.Metro.PrismApp.ViewModels;

namespace MahApps.Metro.PrismApp.Views
{
    /// <summary>
    /// Interaction logic for FlyoutRight.xaml
    /// </summary>
    public partial class FlyoutRight
    {
        public FlyoutRight()
        {
            InitializeComponent();            
            DataContext = new FlyoutDefaultViewModel("Right", Position.Right, nameof(FlyoutRight));

        }
    }
}
