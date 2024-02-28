using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practices;

internal class WaterBottle
{
    private readonly double _capacity;
    private double water;
    public string Model {  get;  private set; } //auto property
    public double Water 

    { 

        get  => water;
        
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
        Model = "ABC";
    }

    public WaterBottle(double capacity, double water) : this(capacity)
    {
        this.water = water;
    }

    ~WaterBottle()
    {
        Model = null;
    }

    public void AddWater(double amount)
    {
        if(water + amount <= _capacity) 

            water += amount;
        

    }
}
