using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonApp.Domain
{
    public class Service
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal PriceWithDiscount { get; set; }

        public Service(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
