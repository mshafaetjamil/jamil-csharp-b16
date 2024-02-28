using Task3;


Console.WriteLine("Enter Rectangle Height:");

double recHeight = int.Parse(Console.ReadLine());

Console.WriteLine("Enter  Rectangle Width:");

double recWidth = int.Parse(Console.ReadLine());

Rectangle rectangle = new Rectangle(recHeight, recWidth);

Console.WriteLine("Rectangle Area:" + rectangle.CalculateArea());

Console.WriteLine("Rectangle Perimeter:" + rectangle.CalculatePerimeter());
Console.WriteLine();


Console.WriteLine("Enter Triangle Side1");

double TriSide1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Triangle Side2");

double TriSide2 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Triangle Side2");

double TriSide3 = int.Parse(Console.ReadLine());

Triangle triangle = new Triangle(TriSide1, TriSide2, TriSide3);

Console.WriteLine("Triangle Area:" + triangle.CalculateArea());

Console.WriteLine("Triangle Perimeter:" + triangle.CalculatePerimeter());
Console.WriteLine();


Console.WriteLine("Enter Circle Radius");

double CirRadius = int.Parse(Console.ReadLine());

Circle circle = new Circle(CirRadius);

Console.WriteLine("Circle Area:" + circle.CalculateArea());

Console.WriteLine("Circle Perimeter:" + circle.CalculatePerimeter());







