using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example01
{
    internal class ProductListCalculator                                       //7.0宣告ProductListCalculator計算機來算總價
    {
        public List<Product> ProductList;                                      //7.1宣告List資結構：List<Product>，表示是由Product類別串接而成的List

        public void ShowReport()
        {
            double totalPrice = 0.0;
            for (int index = 0; index < ProductList.Count; index++)             //7.2算List的數量用.Count
            {
                totalPrice += ProductList[index].Price * ProductList[index].Amount;
                Console.WriteLine(ProductList[index].ToString());
            }

            Console.WriteLine("總價是:{0}", totalPrice);
        }
    }
}