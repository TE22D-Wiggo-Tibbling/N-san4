public class Book
{
    private string Name;
    private int Pages;

    private int CurrentPage = 0;

    public void TurnPage()
    {
        CurrentPage++;
    }

    public int GetCurrentPage()
    {
        return CurrentPage;
    }

    public Book(string name, int page)
    {
        Name = name;
        Pages = page;
    }

    string GetName()
    {
        return Name;
    }

    int GetPage()
    {
        return Pages;
    }

}
