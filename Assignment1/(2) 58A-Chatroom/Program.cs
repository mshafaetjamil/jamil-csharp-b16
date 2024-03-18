string s = Console.ReadLine().Trim();
string hello = "hello";
int index = 0;
foreach (char letter in s)
    if (index < hello.Length && letter == hello[index]) index++;
Console.WriteLine(index == hello.Length ? "YES" : "NO");