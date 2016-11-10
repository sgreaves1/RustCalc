using MyLibrary.SelectPanel;

namespace RustCalc.Model
{
    public class Component : BaseModel, IPanelItem
    {
        private string _name;

        public Component(string name)
        {
            Name = name;
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

        public bool IsSelected { get; set; }
    }
}
