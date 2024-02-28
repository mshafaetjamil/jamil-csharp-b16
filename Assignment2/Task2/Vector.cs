using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2;

public struct Vector
{
    private readonly Fraction X; private readonly Fraction Y;

    public Vector (Fraction x, Fraction y)
    {
        X = x; Y = y;
    }


    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.X+v2.X, v1.Y+v2.Y);
    }

    public static Vector operator -(Vector v1, Vector v2)
    {
        return new Vector(v1.X - v2.X, v1.Y - v2.Y);
    }

    public static Vector operator *(Fraction scaler, Vector v)
    {
        return new Vector(scaler *v.X, scaler *v.Y);
    }

    public static Vector operator *( Vector v, Fraction scaler )
    {
        return scaler * v;
    }

    public static Fraction operator *(Vector v1, Vector v2)
    {
        return (v1.X * v2.X) + (v1.Y * v2.Y);
    }

    public override string ToString()
    {
            return $"({X},{Y})";
    }


}
