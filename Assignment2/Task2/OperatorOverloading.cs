using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task2;

public readonly struct Fraction
{
    private readonly int _numerator;
    private readonly int _denominator;

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;

        if (denominator == 0)
        {
            throw new ArgumentException("Denomonator can't be zero.", nameof(denominator));
        }
    }
    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a= temp;
        }
        return a;

    }

    public static Fraction operator +(Fraction a) => a;

    public static Fraction operator -(Fraction a) => new Fraction(-a._numerator, a._denominator);

    public static Fraction operator +(Fraction a, Fraction b) => new Fraction(a._numerator * b._denominator + b._numerator * a._denominator, a._denominator * b._denominator);

    public static Fraction operator -(Fraction a, Fraction b) => a + (-b);


    public static Fraction operator *(Fraction a, Fraction b) => new Fraction(a._numerator * b._numerator, a._denominator * b._denominator);

    public static Fraction operator /(Fraction a, Fraction b) 
    
    {
    if (b._numerator == 0) 

        {
            throw new DivideByZeroException();
        }

        return new Fraction(a._numerator * b._denominator, a._denominator * b._numerator);


    }

 


    public override string ToString() => $"{_numerator}/{_denominator}";


}
