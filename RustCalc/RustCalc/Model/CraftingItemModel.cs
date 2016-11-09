using System.Collections.ObjectModel;
using System.ComponentModel.Design.Serialization;
using MyLibrary.SelectPanel;

namespace RustCalc.Model
{ 
    public class CraftingItemModel : BaseModel, IPanelItem
    {
        private string _name;
        private string _imageUri;
        private bool _isSelected;

        private ObservableCollection<Component> _components; 

        public CraftingItemModel(string name, string imageUri, ObservableCollection<Component> components)
        {
            Name = name;
            ImageUri = imageUri;
            IsSelected = false;

            Components = components;
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

        public ObservableCollection<Component> Components
        {
            get { return _components; }
            set
            {
                _components = value;
                OnPropertyChanged();
            }
        } 
    }

    
}
