using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Car
    {
        private int id;
        protected int Serial
        {
            get; set;
        }

        public Car()
        {
            id = 100;
        }

        public string Model { get; set; }
        public double Speed { get; set; }

        public void StartEngine()
        {
            Console.WriteLine($"Engine started, id:{id}");
        }
    }
}
