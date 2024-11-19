public class Processorer : Hardware
{

    private int Kärnor;

    private int KlockHastighet;
    public Processorer(string name, int price, int kärnor, int klockHastighet) : base(name, price)
    {
        Kärnor = kärnor;
        KlockHastighet = klockHastighet;
    }

    public int GetKärnor(){
        return Kärnor;
    }

    public int GetKlockHAstighet(){
        return KlockHastighet;
    }
}
