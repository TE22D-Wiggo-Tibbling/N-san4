public class Hårddisk : Hardware
{
    private int TB;
    private int avalible_space;
    public Hårddisk(string name, int price, int size, int space) : base(name, price)
    {
        TB = size;
        avalible_space = space;
    }

    public int GetTB()
    {
        return TB;
    }
    public int GetAvalible_space()
    {
        return avalible_space;
    }

}
