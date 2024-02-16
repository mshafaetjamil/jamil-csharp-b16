using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Product
    {
        public string Description { get; set; }
        public double Price { get; set; }
        
        protected string SKU { get; set; }

        public Product(string name, string description, double price, string sKU)
        {
            Name = name;
            Description = description;
            Price = price;
            SKU = sKU;

            FormatSKU();
        }

        ~Product() { }

        public override double GetDiscount(double discount)
        {
            return Price * discount / 100;
        }
    }
}
