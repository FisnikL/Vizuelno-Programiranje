using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    public class Product
    {
        public string Ime { get; set; }
        public string Kategorija { get; set; }
        public decimal Cena { get; set; }
        public decimal Kolicina { get; set; }

        public override string ToString()
        {
            return Ime;
        }
    }
}
