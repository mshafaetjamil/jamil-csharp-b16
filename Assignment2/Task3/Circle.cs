using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3;

public class Circle : IShape
{
    private double Radius;


    public Circle(double radius)
    {
        Radius = radius;
    }
    public double CalculateArea() => Math.PI * Radius * Radius;


    public double CalculatePerimeter() => 2 * Math.PI * Radius;

}