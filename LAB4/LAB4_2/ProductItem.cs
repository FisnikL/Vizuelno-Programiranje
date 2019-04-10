using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    public class ProductItem
    {
        public Product Product { get; set; }
        public decimal Kolicina { get; set; }
        public override string ToString()
        {
            return Product.Ime + " " + string.Format("{0:0.0}", Kolicina) + " x " + string.Format("{0:0.0}", Product.Cena) +
                " = " + string.Format("{0:0.00}", Kolicina *Product.Cena);
        }
    }
}
