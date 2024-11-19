public class Hardware
{
    private string Name;
    private int Price;

    public Hardware(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public string GetName()
    {
        return Name;
    }

    public int GetPrice()
    {
        return Price;
    }
}
