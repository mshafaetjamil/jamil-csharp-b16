{
    string vowels = "AEIOUYaeiouy";

    string inputString = Console.ReadLine().Trim();

    foreach (char c in inputString)
    {
        if (!vowels.Contains(c))
        {
            Console.Write("." + char.ToLower(c));
        }
    }
}
