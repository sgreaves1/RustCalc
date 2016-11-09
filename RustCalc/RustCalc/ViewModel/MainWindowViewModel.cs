using System.Collections.ObjectModel;
using MyLibrary.SelectPanel;
using RustCalc.Model;

namespace RustCalc.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private ObservableCollection<IPanelItem> _craftableItems = new ObservableCollection<IPanelItem>();
        private IPanelItem _selectedItem;

        public MainWindowViewModel()
        {
            CraftableItems.Add(new CraftingItemModel("Rocket"));
            CraftableItems.Add(new CraftingItemModel("Satchel Charge"));
            CraftableItems.Add(new CraftingItemModel("Timed Mine"));
        }

        public ObservableCollection<IPanelItem> CraftableItems
        {
            get { return _craftableItems; }
            set
            {
                _craftableItems = value;
                OnPropertyChanged();
            }
        }

        public IPanelItem SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged();
            }
        }
    }
}
