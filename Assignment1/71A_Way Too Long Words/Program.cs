{
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        string word = Console.ReadLine();
        if (word.Length > 10)
        {
            string abbreviatedWord = Abbreviate(word);
            Console.WriteLine(abbreviatedWord);
        }
        else
        {
            Console.WriteLine(word);
        }
    }
}

static string Abbreviate(string word)
{
    return $"{word[0]}{word.Length - 2}{word[^1]}";
}
