int n = int.Parse(Console.ReadLine());
int maxLimit = 100000;

if (1 <= n && n <= maxLimit)
{
    string outcomes = Console.ReadLine();

    int antonCount = outcomes.Count(c => c == 'A');
    int danikCount = outcomes.Count(c => c == 'D');

    Console.WriteLine(antonCount > danikCount ? "Anton" : antonCount < danikCount ? "Danik" : "Friendship");
}

    