using System.Windows;
using MyLibrary.SelectPanel;
using RustCalc.Model;

namespace RustCalc.UserControl
{
    /// <summary>
    /// Interaction logic for CraftingDetails.xaml
    /// </summary>
    public partial class CraftingDetails
    {
        public static readonly DependencyProperty ItemProperty =
            DependencyProperty.Register("Item", 
                typeof(CraftingItemModel), 
                typeof(CraftingDetails), 
                new PropertyMetadata(null));
        
        public CraftingDetails()
        {
            InitializeComponent();
        }

        public CraftingItemModel Item
        {
            get { return (CraftingItemModel)GetValue(ItemProperty); }
            set { SetValue(ItemProperty, value); }
        }
    }
}
