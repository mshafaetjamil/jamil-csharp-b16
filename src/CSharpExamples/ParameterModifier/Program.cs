// See https://aka.ms/new-console-template for more information

using ParameterModifier;

Test test = new Test();
int r1 = test.Sum("hello", 2, 3, 6, 7);

var t = 5;
test.Method(ref t);
Console.WriteLine(t);

var t2 = 9;
test.Method2(in t2);
Console.WriteLine(t2);

var t3 = 10;
test.Method3(out t3);
Console.WriteLine(t3);

