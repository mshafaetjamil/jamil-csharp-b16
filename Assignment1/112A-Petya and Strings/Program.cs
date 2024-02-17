{
    string string1 = Console.ReadLine().ToLower();
    string string2 = Console.ReadLine().ToLower();

    if (string1.CompareTo(string2) < 0)
    {
        Console.WriteLine("-1");
    }
    else if (string1.CompareTo(string2) > 0)
    {
        Console.WriteLine("1");
    }
    else
    {
        Console.WriteLine("0");
    }
}