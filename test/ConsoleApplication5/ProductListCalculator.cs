using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class ProductListCalculator
    {
        public List<Product1> ProductList;

        public void ShowReport()
        {
            double totalPrice = 0.0;
            for (int index = 0; index < ProductList.Count; index++)
            {
                totalPrice += (ProductList[index].Price * ProductList[index].Amount);
                Console.WriteLine(ProductList[index].ToString());
            }
            Console.WriteLine("總價是: {0}", totalPrice);
        }
    }
}