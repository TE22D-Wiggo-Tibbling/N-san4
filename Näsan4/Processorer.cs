public class Processorer : Hardware
{

    private int Kärnor;

    private int KlockHastighet;
    private string Mrke = "Ryzen";

    public Processorer(string name, int price, int kärnor, int klockHastighet, string mrke) : base(name, price)
    {
        Kärnor = kärnor;
        KlockHastighet = klockHastighet;
        Mrke =mrke;
    }

    public int GetKärnor()
    {
        return Kärnor;
    }

    public int GetKlockHAstighet()
    {
        return KlockHastighet;
    }
    public string GetMrke()
    {
        return Mrke;
    }

}
