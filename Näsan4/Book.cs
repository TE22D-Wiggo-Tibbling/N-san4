public class Book
{
    public string Name;
    public int Pages;

    private int CurrentPage = 0;

    public void TurnPage()
    {
        CurrentPage++;
    }

    public int GetCurrentPage()
    {
        return CurrentPage;
    }

}
