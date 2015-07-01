using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class Product1
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

        public Product1(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()
        {
            return string.Format("{0}, 數量:{1}, 小記:{2}", this.Name, this.Amount, this.Price * this.Amount);
        }

        public void SaySomething()
        {
            Console.WriteLine("這是Product類別的SaySomething()");
        }
    }
}