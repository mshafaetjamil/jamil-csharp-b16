
using Classes;
using Inheritance;

BMW bmw = new BMW();
bmw.Model = "X60";
bmw.Price = 200000;
bmw.Speed = 100;
bmw.StartEngine();

WaterBottle waterBottle = new WaterBottle(200);
Classes.Car c1 = new Classes.Car();
Inheritance.Car c2 = new Inheritance.Car();


Inheritance.Car car = new BMW();
car.StartEngine();
