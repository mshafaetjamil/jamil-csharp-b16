static int CalculateTramCapacity(int n, (int exit, int enter)[] stops)
{
    int maxCapacity = 0, currentCapacity = 0;

    foreach (var (exit, enter) in stops)
        maxCapacity = Math.Max(maxCapacity, currentCapacity = currentCapacity - exit + enter);

    return maxCapacity;
}

{
    int n = int.Parse(Console.ReadLine());
    var stops = new (int exit, int enter)[n];
    for (int i = 0; i < n; i++)
    {
        var stopData = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        stops[i] = (stopData[0], stopData[1]);
    }

    Console.WriteLine(CalculateTramCapacity(n, stops));
}