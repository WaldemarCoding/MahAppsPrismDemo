using MahApps.Metro.Controls;
using MahApps.Metro.PrismApp.ViewModels;

namespace MahApps.Metro.PrismApp.Views
{
    /// <summary>
    /// Interaction logic for FlyoutBottom.xaml
    /// </summary>
    public partial class FlyoutBottom
    {
        public FlyoutBottom()
        {
            InitializeComponent();
            DataContext = new FlyoutDefaultViewModel("Bottom", Position.Bottom, nameof(FlyoutBottom));
        }
    }
}
