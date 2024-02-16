﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public virtual double CalculateDiscount()
        {
            return Price / 10;
        }
    }
}
