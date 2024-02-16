using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Product : BaseProduct, IDisposable
    {
        private const int _hash = 987478353;
        public string Name { get; set; }

        public Product() { }

        private void FormatSKU()
        {
            SKU = _hash.ToString();
        }

        public void Dispose()
        {
            SKU = null;
        }
    }
}
