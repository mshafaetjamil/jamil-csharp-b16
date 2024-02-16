using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Vehicle
    {
        public double Speed { get; set; }

        public abstract void StartEngine();

        public virtual void Stop()
        {
            Console.WriteLine("Stopping");
        }
    }
}
