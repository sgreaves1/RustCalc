using System.Collections.ObjectModel;
using System.Windows;
using MyLibrary.SelectPanel;
using RustCalc.Model;

namespace RustCalc.UserControl
{
    /// <summary>
    /// Interaction logic for ItemsList.xaml
    /// </summary>
    public partial class ItemsList 
    {
        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", 
                typeof(string), 
                typeof(ItemsList), 
                new PropertyMetadata("Title:"));
        
        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource", 
                typeof(ObservableCollection<IListItem>), 
                typeof(ItemsList), 
                new PropertyMetadata(null));
        
        public ItemsList()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public ObservableCollection<IListItem> ItemsSource
        {
            get { return (ObservableCollection<IListItem>)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }
    }
}
