using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3;

public class Triangle
{
    private double Side1 { get; }
    private double Side2 { get; }
    private double Side3 { get; }

    public Triangle(double side1, double side2, double side3)
    {
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }

    public double CalculateArea()
    {
        double s = (Side1 + Side2 + Side3) / 2;
        return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
    }
    public double CalculatePerimeter() => Side1 + Side2 + Side3;
 



}
