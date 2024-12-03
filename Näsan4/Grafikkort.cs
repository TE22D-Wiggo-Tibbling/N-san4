public class Grafikkort : Hardware
{
    private int Vram;
    private int clockspeed;
    private int PowerDraw;

    public Grafikkort(string name, int price, int vram, int klockHastighet, int kraftdrag) : base(name, price)
    {
        Vram = vram;
        clockspeed = klockHastighet;
        PowerDraw = kraftdrag;
    }

    public int GetVram()
    {
        return Vram;
    }
    public int Getclockspeed()
    {
        return clockspeed;
    }
    public int GetPowerDraw()
    {
        return PowerDraw;
    }


}
