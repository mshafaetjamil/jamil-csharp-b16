using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Camera : Electronics
    {
        public override double CalculateDiscount()
        {
            return base.CalculateDiscount();
        }
    }
}
