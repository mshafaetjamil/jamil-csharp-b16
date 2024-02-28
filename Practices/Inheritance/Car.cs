using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Inheritance;

    public class Car
    {
        private int _id;
        protected int Serial
        {
            get; set;
        }
        public Car() 
        {
            _id = 100;
        }
        public string Model { get; set; }
        public double Speed { get; set; }
        public void StartEngine()
        {
            Console.WriteLine($"Engine Started, id:{_id}");
        }
    }
   

