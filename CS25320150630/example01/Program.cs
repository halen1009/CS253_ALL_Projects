using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Product iphone6 = new Product("iPhone6", 28000.0);              //5.1宣告Product iPhone、宣告CPU cpu
            CPU cpu = new CPU("Intel i7 4970", 12000.0, 3.8);

            iphone6.SaySomething();                                        //5.2Product類別的SaySomething()、CPU類別的SaySomething()
            Console.WriteLine("上面是iphone6的\n");
            cpu.SaySomething();
            Console.WriteLine("上面是cpu的\n");

            iphone6.Amount = 1;                                             //7.3等一下7.X才會用到的

            Product anotherCPU = new CPU("Intel i3 4370", 6000.0, 3.5);     //6.1真正物件導向的寫法：左邊宣告成最上層的類別、右邊寫成子類別
            anotherCPU.SaySomething();                                      //6.2再寫下=new之前，Product anotherCPU的宣告，只是定義了一張貼紙而已；直到new出來後，才會在記憶體中劃出位置
            Console.WriteLine("上面是anotherCPU的(拿掉override)\n");        //   這種寫法是把子類別的CPU，裝箱成Product
            //anotherCPU.f                                                  //6.3.1因為anotherCPU屬於Product類別，所以看不到CPU特有的Frequency
            //                                                                6.3.2但這時的SaySomething()卻是CPU裡面的，因為用了override會指定要使用CPU的SaySomething()

            (anotherCPU as CPU).SaySomething();                             //6.4拿掉override後，要用 (anotherCPU as CPU)來叫CPU的SyaSomething()
            Console.WriteLine("上面是anotherCPU的(用了as CPU)\n");

            //anotherCPU.Amount = 3;                                          //7.3等一下7.才會用到的

            //ProductListCalculator calculator = new ProductListCalculator(); //7.4宣告一個ProductListCalculator
            //calculator.ProductList = new List<Product>();                   //7.5把ProductList給new出來
            //calculator.ProductList.Add(iphone6);                            //7.6把calaulator的ProductList加入iphone6、iphone6、anotherCPU
            //calculator.ProductList.Add(iphone6);
            //calculator.ProductList.Add(anotherCPU);
            //calculator.ShowReport();

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Product2[] products = new Product2[5];                              //11.5改寫Array.Sort，用來排序Product2型別
            products[0] = new Product2("Product1", 1500);
            products[1] = new Product2("Product2", 1200);
            products[2] = new Product2("Product3", 2500);
            products[3] = new Product2("Product4", 3000);
            products[4] = new Product2("Product5", 900);

            Console.WriteLine("排序前");
            for (int index = 0; index < products.Length; index++)
            {
                Console.WriteLine(products[index].Price);
            }

            Array.Sort(products);
            Console.WriteLine("排序後");
            for (int index = 0; index < products.Length; index++)
            {
                Console.WriteLine(products[index].Price);
            }
        }
    }
}