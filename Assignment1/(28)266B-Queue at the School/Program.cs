var inputs = Console.ReadLine().Split();
int n = int.Parse(inputs[0]), t = int.Parse(inputs[1]);
var q = Console.ReadLine().ToCharArray();

for (int sec = 0; sec < t; sec++)
{
    for (int i = 0; i < n - 1; i++)
    {
        if (q[i] == 'B' && q[i + 1] == 'G')
        {

            char temp = q[i];
            q[i] = q[i + 1];
            q[i + 1] = temp;
 
            i++;
        }
    }
}

Console.WriteLine(new string(q));