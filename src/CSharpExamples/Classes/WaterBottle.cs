// Access modifiers : public, internal, protected, private
namespace Classes;

public class WaterBottle
{
    private readonly double _capacity;
    private double _water;

    public string Model { get; private set; }

    public double Water
    {
        get => _water;

        set
        {
            if (value >= 0)
            {
                _water = value;
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
        _water = water;
    }

    ~WaterBottle()
    {
        Model = null;
    }

    public void AddWater(double amount)
    {
        if (_water + amount <= _capacity)
            _water += amount;
    }
}


