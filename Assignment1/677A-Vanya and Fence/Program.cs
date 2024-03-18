var n = Console.ReadLine().Split();
var h = int.Parse(n[1]);
Console.WriteLine(Console.ReadLine().Split().Sum(x => int.Parse(x) > h ? 2 : 1));
