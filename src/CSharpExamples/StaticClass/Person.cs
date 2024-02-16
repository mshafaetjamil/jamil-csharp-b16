using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public class Person
    {
        public static int Serial;
        public string Name;

        public void PrintSerial()
        {
            Console.WriteLine(Serial);
        }
    }
}
