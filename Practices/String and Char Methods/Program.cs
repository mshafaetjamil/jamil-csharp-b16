//string s = "Hello Bokless";
//int index = s.IndexOf('o');
//Console.WriteLine(index);

//string line = Console.ReadLine();
//char characterToCheck = Console.ReadKey().KeyChar;
//bool result = line.Contains(characterToCheck.ToString());
//Console.WriteLine();
//Console.WriteLine(result);


//string line2 = Console.ReadLine();
//string stringToCheck = Console.ReadLine();
//bool result2 = false;
//result2 = line2.Contains(stringToCheck);

//Console.WriteLine();
//Console.WriteLine(result2);

//Console.WriteLine(string.Compare("aaa", "AAA", true));



//char c = 'z';
//Console.WriteLine(char.IsLetter(c));





string[] names = { "Bob", "Marley", "Snoop", "Dog" };
Array.Sort(names, (x, y) => string.Compare(x, y));

foreach (var name in names)
{
    Console.WriteLine(name);
}
