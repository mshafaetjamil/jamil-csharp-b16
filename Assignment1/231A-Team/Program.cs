{
    int n = int.Parse(Console.ReadLine());

    int problemsToImplement = 0;

    for (int i = 0; i < n; i++)
    {
        string[] opinions = Console.ReadLine().Split();

        int petya = int.Parse(opinions[0]);
        int vasya = int.Parse(opinions[1]);
        int tonya = int.Parse(opinions[2]);

        int sureCount = petya + vasya + tonya;

        if (sureCount >= 2)
        {
            problemsToImplement++;
        }
    }

    Console.WriteLine(problemsToImplement);
}

