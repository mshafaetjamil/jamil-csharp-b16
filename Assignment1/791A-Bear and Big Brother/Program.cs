{
    var weights = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int years = 0;
    for (int a = weights[0], b = weights[1]; a <= b; years++)
        (a, b) = (a * 3, b * 2);
    Console.WriteLine(years);
}