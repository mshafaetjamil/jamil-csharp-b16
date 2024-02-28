using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Static_Class;

    public static class Printer
    {
        private static int count = 0;
        public static string DefaultMessage {  get; private set; }
        public static void PrintMessage(string message)
        {
            if(string.IsNullOrEmpty(message))
                message = DefaultMessage;
            Console.WriteLine(message);

          count++;
        }
    }

