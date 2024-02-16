using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public static class Printer
    {
        private static int count = 0;
        public static string DefaultMessage { get; private set; } 
        public static void PrintMessage(string message)
        {
            if(string.IsNullOrWhiteSpace(message))
                message = DefaultMessage;

            Console.WriteLine(message);

            count++;
        }
    }
}
