{
    Console.WriteLine("Enter the dimensions of the Board");

    string[] dimensions = Console.ReadLine().Split();

    int M = int.Parse(dimensions[0]);

    int N = int.Parse(dimensions[1]);

    int totalSquare = M * N;

    if (M < 1 || M > 16 || N < 1 || N > 16 || M > 16 || N > 16)
    {
        Console.WriteLine("Invalid Input! Range is 1 ≤ M ≤ N ≤ 16");
    }

    int maxDominos = totalSquare / 2;

    Console.WriteLine(maxDominos);

}