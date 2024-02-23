decimal sum = 0;

int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    sum += int.Parse(Console.ReadLine());
}
decimal average = sum / count;

Console.WriteLine(average.ToString("0.00000"));




while (average > 0)
{
    Console.WriteLine(average--.ToString("0.00000"));
}

int x = 0;
do
{
    Console.WriteLine(x);
    x++;
} while (x > 0 && x < 10);


while (true)
{
    string text = Console.ReadLine();
    if (text == null) break;
    if (text == "") continue;
    if (text == "end") break;
    Console.WriteLine(text);
}
int[] agess = [23, 33, 45, 60];

foreach (var age in agess)
{
    Console.WriteLine(age);
}