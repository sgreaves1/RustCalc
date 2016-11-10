namespace RustCalc.Model
{
    public interface IListItem
    {
        string Name { get; set; }
        string ImageSource { get; set; }
        int Quantity { get; set; }
    }
}
