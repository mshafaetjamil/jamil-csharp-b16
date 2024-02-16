
using EnumExamples;

void PrintGrettings(string name, Gender type)
{
    if (type == Gender.Male)
        Console.WriteLine("Dear sir, " + name);
    else if (type == Gender.Female)
        Console.WriteLine("Dear madam, " + name);
}

PrintGrettings("tareq", Gender.Female);
