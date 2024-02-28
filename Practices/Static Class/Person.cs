using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class
{
    public class Person
    {
        public static int Serial;
        public string Name;

        public void  PrintMessage() 
        {
            Console.WriteLine(Name);
            Console.WriteLine(Serial);
        }
    }
}
