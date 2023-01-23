using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace price_tags
{
    class Product
    {
        public String Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        //Common product
       public virtual string PriceTag()
        {
            return $"{Name} $ {Price} ";
        }
    }
}
