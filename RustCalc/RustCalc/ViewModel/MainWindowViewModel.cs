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
            CraftableItems.Add(new CraftingItemModel(
                "Rocket", 
                "http://vignette1.wikia.nocookie.net/play-rust/images/9/95/Rocket_icon.png/revision/latest?cb=20151106061039",
                new ObservableCollection<IListItem>() {new Component("Metal Pipe", 1, "http://vignette2.wikia.nocookie.net/play-rust/images/4/4a/Metal_Pipe_icon.png/revision/latest?cb=20161109045929" )}));

            CraftableItems.Add(new CraftingItemModel(
                "Satchel Charge", 
                "http://vignette2.wikia.nocookie.net/play-rust/images/0/0b/Satchel_Charge_icon.png/revision/latest?cb=20160813023035",
                new ObservableCollection<IListItem>()));

            CraftableItems.Add(new CraftingItemModel(
                "Timed Mine", 
                "http://vignette1.wikia.nocookie.net/play-rust/images/6/6c/Timed_Explosive_Charge_icon.png/revision/latest?cb=20151106061610",
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
