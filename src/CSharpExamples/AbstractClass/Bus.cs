using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Bus : Vehicle
    {
        public string Model { get; set; }

        public override void StartEngine()
        {
            Console.WriteLine("Starting engine of bus");
        }

        public override void Stop()
        {
            Console.WriteLine("Stopping bus");
        }
    }
}
