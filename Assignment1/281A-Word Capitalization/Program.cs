{
    string word = Console.ReadLine();

    string capitalizedWord = CapitalizeWord(word);

    Console.WriteLine(capitalizedWord);
}

static string CapitalizeWord(string word)
{
    if (!string.IsNullOrEmpty(word))
    {
        string capitalizedWord = char.ToUpper(word[0]) + word.Substring(1);
        return capitalizedWord;
    }
    else
    {
        return word;
    }
}