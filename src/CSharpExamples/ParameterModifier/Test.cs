using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterModifier
{
    internal class Test
    {
        public int Sum(string text, params int[] nums)
        {
            var sum = 0;
            foreach(var item in nums)
            {
                sum += item;
            }
            return sum;
        }

        public void Method(ref int x)
        {
            if (x == 5)
                x = 9;
        }

        public void Method2(in int x)
        {
            // x = 9;
        }

        public void Method3(out int x)
        {
            x = 9;
        }
    }
}
