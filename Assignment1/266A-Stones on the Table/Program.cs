{
    int n = int.Parse(Console.ReadLine());
    string s = Console.ReadLine();       

    int stonesToRemove = 0;

    for (int i = 1; i < n; i++)
    {

        if (s[i] == s[i - 1])
        {
            stonesToRemove++;
        }
    }

    Console.WriteLine(stonesToRemove);
}