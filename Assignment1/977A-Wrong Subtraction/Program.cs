{
    string[] inputs = Console.ReadLine().Split(' ');
    int n = int.Parse(inputs[0]);
    int k = int.Parse(inputs[1]);

    for (int i = 0; i < k; i++)
    {
        if (n % 10 != 0)
            n -= 1;
        else
            n /= 10;
    }

    Console.WriteLine(n);
}