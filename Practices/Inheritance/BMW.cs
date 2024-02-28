using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance;

public class BMW : Car
{
    public BMW ()
    {
        Serial = 2000;
    }
    public double Price { get; set; }

    public new void StartEngine()
    {
        Console.WriteLine("BMW engine started");
    }

}
