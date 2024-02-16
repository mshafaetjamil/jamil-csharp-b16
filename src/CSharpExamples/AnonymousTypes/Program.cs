
var item = new { Name = "Jalaluddin", Age = 12 };

Console.WriteLine(item.Name);
Console.WriteLine(item.Age);


dynamic GetRange(int[] numbers)
{
    return new { Min = numbers.Min(), Max = numbers.Max() };
}


var result = GetRange([2, 5, 9, 3, 7]);

Console.WriteLine($"Min: {result.Min}, Max:{result.Max}");