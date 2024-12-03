// // Steg 1

// Book olle = new() {Name = "Hej", Pages = 2}; 
// Book bolle = new() {Name = "nej", Pages = 1}; 
// Book colle = new() {Name = "tjej", Pages = 3}; 

// // Steg 2

// olle.TurnPage();
// System.Console.WriteLine(olle.CurrentPage);
// Console.ReadLine();


// Steg 6

// List<Rock> rocks = new();
// int amount = 0;
// int weight;

// System.Console.WriteLine("how many rock?");
// while (!int.TryParse(Console.ReadLine(), out amount)) Console.WriteLine("NO NUMBAR");
// for (int i = 0; i < amount; i++)
// {
//     Console.WriteLine("how hevy");
//     while (!int.TryParse(Console.ReadLine(), out weight)) Console.WriteLine("NO NUMBAR");
//     rocks.Add(new Rock(weight));
// }

// Steg 7

// Worker w = new("hej hej", 5);
// WhiteColla e = new("hej hej", 5);
// BlueColler r = new("hej hej", 5);

// r.SetWage(10);
// r.GetAge();
// r.GetWage();
// r.GetName();

// Console.ReadLine();


// Steg 8

int Awnser;
List<Hardware> hardwareses = new();
while (true)
{
    int price = 0;
    string name = "";


    Console.WriteLine("what you wana make?");
    Console.WriteLine("1. Hårddisk  2. Grafikkort  3. Processor");
    while (!int.TryParse(Console.ReadLine(), out Awnser) && Awnser < 4 && Awnser > 0)
    if (Awnser == 1)
    {
        int size = 0;
        int size2 = 0;

        Console.WriteLine("Skriv namn");
        name = Console.ReadLine();
        Console.WriteLine("Skriv pris");
        while (!int.TryParse(Console.ReadLine(), out price)) Console.WriteLine("Du fel");
        Console.WriteLine("Skriv Storlek");
        while (!int.TryParse(Console.ReadLine(), out size)) Console.WriteLine("Du fel");
        Console.WriteLine("Skriv storlek igen");
        while (!int.TryParse(Console.ReadLine(), out size2)) Console.WriteLine("Du fel");
        hardwareses.Add(new Hårddisk(name, price, size, size2));
    }
    if (Awnser == 2)
    {
        int Vram = 0;
        int Clockspeed = 0;
        int PowerDraw = 0;

        Console.WriteLine("Skriv namn");
        name = Console.ReadLine();
        Console.WriteLine("Skriv pris");
        while (!int.TryParse(Console.ReadLine(), out price)) Console.WriteLine("Du fel");
        Console.WriteLine("Skriv Vram");
        while (!int.TryParse(Console.ReadLine(), out Vram)) Console.WriteLine("Du fel");
        Console.WriteLine("Skriv Clockhastighet");
        while (!int.TryParse(Console.ReadLine(), out Clockspeed)) Console.WriteLine("Du fel");
        Console.WriteLine("Skriv PowerDraw");
        while (!int.TryParse(Console.ReadLine(), out PowerDraw)) Console.WriteLine("Du fel");

        hardwareses.Add(new Grafikkort(name, price, Vram, Clockspeed, PowerDraw));
    }
    if (Awnser == 3)
    {
        int Kärnor = 0;

        int KlockHastighet = 0;
        string Mrke = "ads";

        Console.WriteLine("Skriv namn");
        name = Console.ReadLine();
        Console.WriteLine("Skriv pris");
        while (!int.TryParse(Console.ReadLine(), out price)) Console.WriteLine("Du fel");
        Console.WriteLine("Skriv Vram");
        while (!int.TryParse(Console.ReadLine(), out Kärnor)) Console.WriteLine("Du fel");
        Console.WriteLine("Skriv Clockhastighet");
        while (!int.TryParse(Console.ReadLine(), out KlockHastighet)) Console.WriteLine("Du fel");
        Console.WriteLine("Skriv PowerDraw");
        Mrke = Console.ReadLine();


        hardwareses.Add(new Processorer(name, price, Kärnor, KlockHastighet, Mrke));
    }
}
