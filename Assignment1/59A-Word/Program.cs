{
    string word = Console.ReadLine().Trim();

    int upperCount = 0;
    int lowerCount = 0;

    foreach (char letter in word)
    {
        if (char.IsUpper(letter))
        {
            upperCount++;
        }
        else
        {
            lowerCount++;
        }
    }

    if (upperCount > lowerCount)
    {
        Console.WriteLine(word.ToUpper());
    }
    else
    {
        Console.WriteLine(word.ToLower());
    }
}