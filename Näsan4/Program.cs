// Steg 1

Book olle = new() {Name = "Hej", Pages = 2}; 
Book bolle = new() {Name = "nej", Pages = 1}; 
Book colle = new() {Name = "tjej", Pages = 3}; 

// Steg 2

olle.TurnPage();
System.Console.WriteLine(olle.CurrentPage);
Console.ReadLine();


