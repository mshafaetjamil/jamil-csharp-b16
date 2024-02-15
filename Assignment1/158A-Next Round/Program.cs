{
    string[] nk = Console.ReadLine().Split();
    int n = int.Parse(nk[0]);
    int k = int.Parse(nk[1]);

    string[] scores = Console.ReadLine().Split();
    int[] scoresArray = new int[n];
    for (int i = 0; i < n; i++)
    {
        scoresArray[i] = int.Parse(scores[i]);
    }

    Console.WriteLine(CountAdvancers(scoresArray, k));
}
static int CountAdvancers(int[] scores, int k)
{
    int advancers = 0;
    int kScore = scores[k - 1];

    foreach (int score in scores)
    {
        if (score > 0 && score >= kScore)
        {
            advancers++;
        }
        else
        {
            break;
        }
    }

    return advancers;
}