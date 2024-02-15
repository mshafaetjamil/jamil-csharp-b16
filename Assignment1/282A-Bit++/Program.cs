{
    int n = int.Parse(Console.ReadLine());
    string[] statements = new string[n];
    for (int i = 0; i < n; i++)
    {
        statements[i] = Console.ReadLine();
    }

    int finalValue = ExecuteBitProgram(n, statements);

    Console.WriteLine(finalValue);
}

static int ExecuteBitProgram(int n, string[] statements)
{
    int x = 0;
    foreach (string statement in statements)
    {
        if (statement.Contains("++"))
        {
            x++;
        }
        else if (statement.Contains("--"))
        {
            x--;
        }
    }
    return x;
}