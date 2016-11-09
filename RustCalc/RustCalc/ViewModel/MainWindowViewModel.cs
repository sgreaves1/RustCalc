using System.Collections.ObjectModel;
using MyLibrary.SelectPanel;
using RustCalc.Model;

namespace RustCalc.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private ObservableCollection<IPanelItem> _craftableItems = new ObservableCollection<IPanelItem>();

        public MainWindowViewModel()
        {
            CraftableItems.Add(new CraftingItemModel("Rocket"));
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
    }
}
