using OperatorOverloading;

int x = 5;
int y = 7;
int z = x + y;


Fraction a = new Fraction { Numerator = 7, Demoninator = 9 };
Fraction b = new Fraction { Numerator = 2, Demoninator = 3 };

Fraction c = a + b;

Console.WriteLine(c);