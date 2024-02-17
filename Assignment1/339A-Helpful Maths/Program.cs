{
    string[] parts = Console.ReadLine().Split('+');

    int[] numbers = parts.Select(int.Parse).OrderBy(x => x).ToArray();

    string newSum = string.Join("+", numbers);

    Console.WriteLine(newSum);
}