using MyLibrary.SelectPanel;

namespace RustCalc.Model
{ 
    public class CraftingItemModel : BaseModel, IPanelItem
    {
        private string _name;
        private string _imageUri;
        private bool _isSelected;

        public CraftingItemModel(string name, string imageUri)
        {
            Name = name;
            ImageUri = imageUri;
            IsSelected = false;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string ImageUri
        {
            get { return _imageUri; }
            set
            {
                _imageUri = value;
                OnPropertyChanged();
            }
        }

        public bool IsSelected
        {
            get {return _isSelected;}
            set
            {
                _isSelected = value;
                OnPropertyChanged();
            }
        }
    }

    
}
