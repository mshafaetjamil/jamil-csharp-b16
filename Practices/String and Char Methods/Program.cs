string s = "Hello Bokless";
int index = s.IndexOf('o');
Console.WriteLine(index);

string line = Console.ReadLine();
char characterToCheck = Console.ReadKey().KeyChar;
bool result = line.Contains(characterToCheck.ToString());
Console.WriteLine();
Console.WriteLine(result);


string line2 = Console.ReadLine();
string stringToCheck = Console.ReadLine();
bool result2 = false;
result2 = line2.Contains(stringToCheck);

Console.WriteLine();
Console.WriteLine(result2);



