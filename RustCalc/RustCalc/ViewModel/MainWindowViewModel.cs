using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RustCalc.Model;

namespace RustCalc.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private ObservableCollection<CraftingItemModel> _craftableItems = new ObservableCollection<CraftingItemModel>();

        public ObservableCollection<CraftingItemModel> CraftableItem
        {
            get { return _craftableItems; }
            set { _craftableItems = value; }
        }  
    }
}
