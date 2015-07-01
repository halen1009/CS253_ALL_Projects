using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example01
{
    internal class Product2 : IComparable<Product2>                        //11.1改用介面：IComparable<Product2>，且縮小資料範圍在Product2型別
    //                                                                       11.2下拉IComparable選第一個
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

        public int CompareTo(Product2 other)                         //11.3下拉後自動產生的介面實做，有了實做的介面以後，就可以做Product的排序了
        {
            if (this.Price > other.Price)
                return 1;
            else if (this.Price == other.Price)
                return 0;
            else
                return -1;
        }
    }
}