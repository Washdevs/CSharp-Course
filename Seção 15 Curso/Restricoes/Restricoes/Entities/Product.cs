using System;
using System.Globalization;
namespace Restricoes.Entities
{
    internal class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name
                + ", "
                + Price;
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("Argumento de comparação Errado");
            }
            Product other = (Product)obj;
            return Price.CompareTo(other.Price);
        }
    }
}