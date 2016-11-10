namespace RustCalc.Model
{
    public class Component : BaseModel, IListItem
    {
        private string _name;
        private string _imageSource;
        private int _quantity;

        public Component(string name, int quantity, string image)
        {
            Name = name;
            ImageSource = image;
            Quantity = quantity;
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

        public string ImageSource
        {
            get { return _imageSource; }
            set
            {
                _imageSource = value;
                OnPropertyChanged();
            }
        }

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
                OnPropertyChanged();
            }
        }

        public bool IsSelected { get; set; }
    }
}
