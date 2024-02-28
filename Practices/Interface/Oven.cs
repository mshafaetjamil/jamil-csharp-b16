using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Oven : IMachine
    {
        public void On()
        {
            Console.WriteLine("Oven On!!");
        }
        public void Off()
        {
            Console.WriteLine("Oven Off!!");
        }

        public void Start()
        {
            On();
        }

        public void Stop()
        {
           Off();
        }
    }
}
