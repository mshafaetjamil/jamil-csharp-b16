﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class WashingMaching : IMachine
    {
        public void Start()
        {
            Console.WriteLine("WashinMachine Started!");
        }

        public void Stop()
        {
            Console.WriteLine("WashinMachine Stopped!");
        }
    }
}
