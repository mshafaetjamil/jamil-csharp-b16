{
    int[,] matrix = new int[5, 5];
    for (int i = 0; i < 5; i++)
    {
        string[] row = Console.ReadLine().Split();
        for (int j = 0; j < 5; j++)
        {
            matrix[i, j] = int.Parse(row[j]);
        }
    }

    int oneRow = -1, oneCol = -1;
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            if (matrix[i, j] == 1)
            {
                oneRow = i;
                oneCol = j;
                break;
            }
        }
        if (oneRow != -1)
            break;
    }

    int moves = Math.Abs(oneRow - 2) + Math.Abs(oneCol - 2);

    Console.WriteLine(moves);
}
