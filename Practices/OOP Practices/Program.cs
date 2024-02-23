//OOP

//1-Array:

string line = Console.ReadLine();
int size = 0;
bool success = false;
success = int.TryParse(line, out size);
if (success)
{
    string[] names = new string[size];
    for (int i = 0; i < size; i++)
    {
        names[i] = Console.ReadLine();
    }
    string middlepersonName = names[names.Length /2];
    Console.WriteLine(middlepersonName);
}
else { Console.WriteLine("Input should be typed in Interger!"); }