namespace RustCalc.Model
{
    public class Component : BaseModel
    {
        private string _name;

        public Component(string name)
        {
            Name = name;
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
    }
}
