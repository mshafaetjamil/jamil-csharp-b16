using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practices
{
    internal class WaterBottle
    {
        private readonly double _capacity;
        private double water;

         public double Water 

        { 

            get 
            {  
                return water; 
                
            } 
            set
            {
                if (value >= 0)
                {
                    water = value;
                }
            }
        
        }

        public WaterBottle(double capacity)
        {
            _capacity = capacity;
        }

        public WaterBottle(double capacity, double water) : this(capacity)
        {
            this.water = water;
        }

        public void AddWater(double amount)
        {
            if(water + amount <= _capacity) 

                water += amount;
 
        }
    }
}
