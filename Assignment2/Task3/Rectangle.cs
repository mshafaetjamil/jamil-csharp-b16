using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3;

public class Rectangle : IShape
{
    private double Height { get; set; }
    private double Width { get; set; }

    public Rectangle(double width, double height)
    {
        Height = height;
        Width = width;
    }
    public double CalculateArea() => Height * Width;
 

    public double CalculatePerimeter() => 2 * (Height + Width);

}
