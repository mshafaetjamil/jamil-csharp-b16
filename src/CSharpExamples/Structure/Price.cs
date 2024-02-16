using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    public struct Price
    {
        public decimal Amount { get; set; }
        public double Discount { get; set; }
        public string Currency { get; set; }

        public Price(decimal amount, double discount)
        {
            Amount = amount;
            Discount = discount;
        }

        public decimal GetPriceAfterDiscount()
        {
            return Amount - (Amount * (decimal)Discount / 100);
        }
    }
}
