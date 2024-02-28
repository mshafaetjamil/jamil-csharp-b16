using System.Collections.Concurrent;
using System.Reflection.Metadata.Ecma335;
using Task2;

var v1 = new Vector(new Fraction(3,4), new Fraction(5,6));
var v2 = new Vector(new Fraction(1,2), new Fraction(2,3));

Console.WriteLine($"Vector 1: {v1}");
Console.WriteLine($"Vector 2: {v2}");


Console.WriteLine($"Addition:{v1} + {v2} = {v1 + v2}");
Console.WriteLine();

Console.WriteLine($"Substraction:{v1} - {v2} = {v1 - v2}");
Console.WriteLine();

Fraction scalar = new Fraction(2, 1);
Console.WriteLine($"Scalar Multiplication: {scalar} * {v1} = {scalar * v2}");
Console.WriteLine();

Console.WriteLine($"Dot Product:{v1} * {v2} = {v1 *v2}");
Console.WriteLine();
