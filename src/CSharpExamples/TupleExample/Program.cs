// See https://aka.ms/new-console-template for more information


(int min, int) GetRange(int[] numbers)
{
    return (numbers.Min(), numbers.Max());
}


(int min, int max) result = GetRange([2, 5, 9, 3, 7]);

Console.WriteLine($"Min: {result.min}, Max:{result.max}");


// person.Address = ("Mirpur", 1216);