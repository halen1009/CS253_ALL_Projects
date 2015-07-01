using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    internal class Product2 : IComparable<Product2>
    {
        public string Name { get; set; }

        public double Price { get; set; }

        private int amount;

        public int Amount
        {
            get { return amount; }
            set
            {
                amount = value < 0 ? 0 : value;
            }
        }

        public Product2(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public int CompareTo(Product2 other)
        {
            if (this.Price > other.Price) return 1;
            else if (this.Price == other.Price) return 0;
            else return -1;
        }
    }
}