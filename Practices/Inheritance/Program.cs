using Inheritance;

BMW bMW = new BMW();
bMW.Model = "XYZ";
bMW.Price = 100000;
bMW.Speed = 100;
bMW.StartEngine();

Console.WriteLine($"Model:{bMW.Model}");
Console.WriteLine($"Price:{bMW.Price}");

Inheritance.Car car = new BMW();
car.StartEngine();

