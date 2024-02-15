{
    string username = Console.ReadLine().Trim();

    Console.WriteLine(CountDistinctCharacters(username) % 2 == 0 ? "CHAT WITH HER!" : "IGNORE HIM!");
}

static int CountDistinctCharacters(string str)
{
    return str.Distinct().Count();
}