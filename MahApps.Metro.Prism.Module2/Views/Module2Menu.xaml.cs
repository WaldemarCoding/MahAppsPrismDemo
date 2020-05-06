using MahApps.Metro.Controls;
using MahApps.Metro.PrismApp.Core;

namespace MahApps.Metro.PrismModule2.Views
{
    /// <summary>
    /// Interaction logic for AccordionMenuItem.xaml
    /// </summary>
    public partial class Module2Menu : HamburgerMenuItemCollection, IMenuRootItem
    {
        public Module2Menu()
        {
            InitializeComponent();
        }

        public string DefaultNavigationPath => nameof(ViewC);
    }
}
