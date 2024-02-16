using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class WashingMachine : IMachine
    {
        public string Name { get; set; }

        public void Start()
        {
            Console.WriteLine("Washing machine started");
        }

        public void Stop()
        {
            Console.WriteLine("Washing machine stopped");
        }
    }
}
