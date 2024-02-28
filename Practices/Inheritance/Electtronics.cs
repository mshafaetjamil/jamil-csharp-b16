using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Electronics : Product //if cant inherit cuz of sealed keyword
    {
        public override double CalculateDiscount()
        {
            return Price / 20;
        }
    }
}
