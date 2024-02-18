{
    int n = int.Parse(Console.ReadLine());
    int x = 0, y = 0, z = 0;

    for (int i = 0; i < n; i++)
    {
        var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        x += input[0];
        y += input[1];
        z += input[2];
    }

    Console.WriteLine(x == 0 && y == 0 && z == 0 ? "YES" : "NO");
}