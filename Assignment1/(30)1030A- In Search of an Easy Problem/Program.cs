{
    int n = int.Parse(Console.ReadLine());
    int[] opinions = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    string result = CheckProblem(n, opinions);
    Console.WriteLine(result);
}

static string CheckProblem(int n, int[] opinions)
{
    foreach (int opinion in opinions)
    {
        if (opinion == 1)
        {
            return "HARD";
        }
    }
    return "EASY";
}