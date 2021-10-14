using System;
using System.Globalization;

namespace Exer_Fixacao_Heranca_Orient_Objeto.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return ($"{Name} $ {Price.ToString("F2",CultureInfo.InvariantCulture)}"); 
        }

    }
}
