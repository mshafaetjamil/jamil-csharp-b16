int y = int.Parse(Console.ReadLine());

while (true)
{
    y++;
    string yearStr = y.ToString();
    bool[] seen = new bool[10];
    bool isDistinct = true;

    foreach (char digit in yearStr)
    {
        int num = digit - '0';
        if (seen[num])
        {
            isDistinct = false;
            break;
        }
        seen[num] = true;
    }

    if (isDistinct)
    {
        Console.WriteLine(y);
        break;
    }
}