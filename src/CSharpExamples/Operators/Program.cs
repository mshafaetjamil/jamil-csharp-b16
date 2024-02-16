// See https://aka.ms/new-console-template for more information

int i = 3;
Console.WriteLine(i);   // output: 3
Console.WriteLine(i++); // output: 3
Console.WriteLine(i);   // output: 4

double a = 1.5;
Console.WriteLine(a);   // output: 1.5
Console.WriteLine(++a); // output: 2.5
Console.WriteLine(a);   // output: 2.5

int i2 = 3;
Console.WriteLine(i2);   // output: 3
Console.WriteLine(i2--); // output: 3
Console.WriteLine(i2);   // output: 2

double a2 = 1.5;
Console.WriteLine(a2);   // output: 1.5
Console.WriteLine(--a2); // output: 0.5
Console.WriteLine(a2);   // output: 0.5


int x = 5;
x += 9;  // x = x + 9
int y = x + 9;
Console.WriteLine(x);  // output: 14

x -= 4;
Console.WriteLine(x);  // output: 10

x *= 2;
Console.WriteLine(x);  // output: 20

x /= 4;
Console.WriteLine(x);  // output: 5

x %= 3;
Console.WriteLine(x);  // output: 2


uint m = 0b_1100_1001_0000_0000_0000_0000_0001_0001;
uint n = 0x_AF5;

Console.WriteLine($"Before: {Convert.ToString(m, toBase: 2)}");

m = m << 4;
Console.WriteLine($"After:  {Convert.ToString(m, toBase: 2)}");

uint s = 0b_1001;
Console.WriteLine($"S Before: {Convert.ToString(s, toBase: 2), 4}");

uint s2 = s >> 2;
Console.WriteLine($"S After:  {Convert.ToString(s2, toBase: 2), 4}");



uint a1 = 0b_1111_1000;
uint b1 = 0b_1001_1101;
//           1001_1000


uint c1 = a1 & b1;
Console.WriteLine(Convert.ToString(c1, toBase: 2));

uint p = 0b_1111_1000;
uint q = 0b_1001_1101;
uint r = p | q;
Console.WriteLine(Convert.ToString(r, toBase: 2));
// Output:
// 11111101

uint w = 0b_1111_1000;
uint v = 0b_0001_1100;
uint z = w ^ v;
Console.WriteLine(Convert.ToString(z, toBase: 2));
// Output:
// 11100100


int number1 = 5;
int number2 = 10;

bool result = number1 == number2;
bool result2 = number1 > number2;
bool result3 = number1 != number2;
bool result4 = number1 >= number2;
bool result5 = number1 <= number2;
bool result6 = number1 < number2;
bool result7 = number1 > number2;
bool result8 = !(number1 < number2);
bool result9 = number1 > 4 && number2 < 11;
bool result10 = number1 > 4 || number2 < 11;

if(number1 == number2)
{
    Console.WriteLine("Numbers are equal");
}
else if(number1 > number2)
{
    Console.WriteLine("Number 1 greater");
}
else if(number1 < number2)
{
    Console.WriteLine("Number 2 is greater");
}






