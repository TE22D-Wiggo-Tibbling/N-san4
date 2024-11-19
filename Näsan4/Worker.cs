public class Worker
{
    protected string Name;
    protected int Age;
    protected int Wage = 0;

    public Worker(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void SetWage(int wage)
    {
        Wage = wage;
    }

    public string GetName()
    {
        return Name;
    }

    public int GetAge()
    {
        return Age;
    }
    public int GetWage()
    {
        return Wage;
    }
}
