using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class;

public partial class Product
{
    private const int _hash = 98764765;

    public string Name { get; set; }
    public string Description { get; set; }

    public double Price { get; set; }

    protected string SKU { get; set; }
    public Product() { }

    public Product(string name, string description, double price, string sKU)
    {
        Name = name;
        Description = description;
        Price = price;
        SKU = sKU;

        FormatSKU();
    }
    ~Product() { }

    public double GetDiscountedAmount(double discount)
    {
        return Price * discount / 100;
    }
    private void FormatSKU()
    {
        SKU = _hash.ToString();
    }
}
