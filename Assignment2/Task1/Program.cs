using Task1;

Console.WriteLine("Enter speed for Battleship:");
int battleshipSpeed = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

var battleship = new Battleship<int>(battleshipSpeed);
Console.WriteLine(battleship.Speed);

var clonedbattleship = battleship.CloneShip();
Console.WriteLine(clonedbattleship.Speed);

Console.WriteLine("");

Console.WriteLine("Enter speed for Cruiser:");
double cruiserSpeed = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");

var cruiser = new Cruiser<double>(cruiserSpeed);
Console.WriteLine(cruiser.Speed);

var clonedCruiser = cruiser.CloneShip();
Console.WriteLine(clonedCruiser.Speed);


