using System;

namespace price_tags.Entities
{
    class ImportedProduct : Product
    {
        public Double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {

            CustomsFee = customsFee;
        }

        public virtual double totalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
