using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class;

public class Bus : Vehicle
{
    public string Model { get; set; }
    public override void StartEngine()
    {
        Console.WriteLine("Starting Engine of Bus");
    }
    public override void Stop()
    {
        Console.WriteLine("Stopping Bus");
    }

}