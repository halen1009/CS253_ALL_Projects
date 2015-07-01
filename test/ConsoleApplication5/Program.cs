using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product1 iphone6 = new Product1("iphone6", 28000.0);
            CPU cpu = new CPU("Intel i7", 12000.0, 3.8);

            iphone6.SaySomething();
            Console.WriteLine();
            cpu.SaySomething();
            Console.WriteLine();

            Product1 anotherCPU = new CPU("Intel i6", 6000.0, 3.5);
            anotherCPU.SaySomething();
            Console.WriteLine();
            //anotherCPU

            (anotherCPU as CPU).SaySomething();
            Console.WriteLine();

            iphone6.Amount = 1;
            anotherCPU.Amount = 3;

            ProductListCalculator calculator = new ProductListCalculator();
            calculator.ProductList = new List<Product1>();
            //calculator.ProductList.Add(iphone6);
            //calculator.ProductList.Add(iphone6);
            calculator.ProductList.Add(anotherCPU);
            calculator.ShowReport();

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Product2[] products = new Product2[5];
            products[0] = new Product2("Product1", 15000);
            products[1] = new Product2("Product1", 12000);
            products[2] = new Product2("Product1", 25000);
            products[3] = new Product2("Product1", 30000);
            products[4] = new Product2("Product1", 9000);

            Console.WriteLine("排序前: ");
            for (int index = 0; index < products.Length; index++)
            {
                Console.WriteLine(products[index].Price);
            }

            Array.Sort(products);

            Console.WriteLine("排序後: ");
            for (int index = 0; index < products.Length; index++)
            {
                Console.WriteLine(products[index].Price);
            }
        }
    }
}