
{
    long n = long.Parse(Console.ReadLine());

    int count = 0;
    foreach (char c in n.ToString())
    {
        if (c == '4' || c == '7')
            count++;
    }

    Console.WriteLine(count == 4 || count == 7 ? "YES" : "NO");
}