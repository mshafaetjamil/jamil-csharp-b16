using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public struct Fraction
    {
        public int Numerator { get; set; }
        public int Demoninator { get; set; }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction
            {
                Numerator = a.Numerator * b.Demoninator + b.Numerator * a.Demoninator,
                Demoninator = a.Demoninator * b.Demoninator
            };
        }

        public override string ToString() => $"{Numerator} / {Demoninator}";
    }
}
