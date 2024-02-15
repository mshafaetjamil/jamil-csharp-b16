{
        string[] input = Console.ReadLine().Split();
        long n = long.Parse(input[0]);
        long m = long.Parse(input[1]);
        long a = long.Parse(input[2]);

        Console.WriteLine(LeastFlagstones(n, m, a));
}

    static long LeastFlagstones(long n, long m, long a)
    {
        long rows = (long)Math.Ceiling((double)n / a);
        long columns = (long)Math.Ceiling((double)m / a);
        return rows * columns;
    }