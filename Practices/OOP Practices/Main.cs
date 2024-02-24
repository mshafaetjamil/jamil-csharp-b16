//OOP

//1-Array:

//string line = Console.ReadLine();
//int size = 0;
//bool success = false;
//success = int.TryParse(line, out size);
//if (success)
//{
//    string[] names = new string[size];
//    for (int i = 0; i < size; i++)
//    {
//        names[i] = Console.ReadLine();
//    }
//    string middlepersonName = names[names.Length /2];
//    Console.WriteLine(middlepersonName);
//}
//else { Console.WriteLine("Input should be typed in Interger!"); }




//Classes
using OOP_Practices;

WaterBottle waterBottle = new WaterBottle(100);
waterBottle.Water = 10;
//waterBottle.capacity = 100;
waterBottle.AddWater(30);

WaterBottle waterBottle2 = new WaterBottle(200);
waterBottle2.Water = 20;
//waterBottle2.capacity = 100;
waterBottle2.AddWater(50);


Console.WriteLine("water in Bottle 1:" + waterBottle.Water);
Console.WriteLine("water in Bottle 2:" + waterBottle2.Water);
