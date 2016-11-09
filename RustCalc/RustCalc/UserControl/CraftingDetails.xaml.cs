using System.Windows;
using MyLibrary.SelectPanel;

namespace RustCalc.UserControl
{
    /// <summary>
    /// Interaction logic for CraftingDetails.xaml
    /// </summary>
    public partial class CraftingDetails
    {
        public static readonly DependencyProperty ItemProperty =
            DependencyProperty.Register("Item", 
                typeof(IPanelItem), 
                typeof(CraftingDetails), 
                new PropertyMetadata(null));
        
        public CraftingDetails()
        {
            InitializeComponent();
        }

        public IPanelItem Item
        {
            get { return (IPanelItem)GetValue(ItemProperty); }
            set { SetValue(ItemProperty, value); }
        }
    }
}
