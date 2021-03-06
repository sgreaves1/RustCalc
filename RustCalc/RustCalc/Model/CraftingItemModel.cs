﻿using System.Collections.ObjectModel;
using MyLibrary.SelectPanel;

namespace RustCalc.Model
{ 
    public class CraftingItemModel : BaseModel, IPanelItem
    {
        private string _name;
        private string _imageUri;
        private bool _isSelected;

        private ObservableCollection<IListItem> _components;

        private ObservableCollection<IListItem> _recipeItems; 

        public CraftingItemModel(string name, string imageUri, ObservableCollection<IListItem> recipeItems, ObservableCollection<IListItem> components)
        {
            Name = name;
            ImageUri = imageUri;
            IsSelected = false;

            Components = components;

            RecipeItems = recipeItems;
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

        public ObservableCollection<IListItem> Components
        {
            get { return _components; }
            set
            {
                _components = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<IListItem> RecipeItems
        {
            get { return _recipeItems; }
            set
            {
                _recipeItems = value;
                OnPropertyChanged();
            }
        }
    }

    
}
