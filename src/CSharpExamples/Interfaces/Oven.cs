using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Oven : IMachine
    {
        public string Name { get; set; }

        public void On()
        {
            Console.WriteLine("Oven On");
        }

        public void Off()
        {
            Console.WriteLine("Oven off");
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
