using System.Collections.ObjectModel;
using MyLibrary.SelectPanel;
using RustCalc.Helper;
using RustCalc.Model;

namespace RustCalc.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private ObservableCollection<IPanelItem> _craftableItems = new ObservableCollection<IPanelItem>();
        private IPanelItem _selectedItem;

        public MainWindowViewModel()
        {
            CraftableItems.Add(new CraftingItemModel(
                "Rocket", 
                ImageUrlStore.GetImageUri("Rocket"),
                new ObservableCollection<IListItem>() {new ItemModel("Gun Powder", 150, ImageUrlStore.GetImageUri("Gun Powder")), new ItemModel("Explosives", 10, ImageUrlStore.GetImageUri("Explosives")) }, 
                new ObservableCollection<IListItem>() {new ItemModel("Metal Pipe", 2, "http://vignette2.wikia.nocookie.net/play-rust/images/4/4a/Metal_Pipe_icon.png/revision/latest?cb=20161109045929" )}));

            CraftableItems.Add(new CraftingItemModel(
                "Satchel Charge",
                ImageUrlStore.GetImageUri("Satchel Charge"),
                new ObservableCollection<IListItem>(),
                new ObservableCollection<IListItem>()));

            CraftableItems.Add(new CraftingItemModel(
                "Timed Mine", 
                ImageUrlStore.GetImageUri("Timed Mine"),
                new ObservableCollection<IListItem>(),
                new ObservableCollection<IListItem>()));
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
