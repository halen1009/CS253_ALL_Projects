using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example01
{
    public class Product				//1.0記得類別權限要改成public
    {
        public string Name { get; set; }                //1.1虛擬欄位，偷懶寫法{ get; set; }

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

        public Product(string name, double price)                       //1.2參數習慣用小寫
        {
            this.Name = name;
            this.Price = price;
        }

        public override string ToString()                               //3.1又來了，常用的override ToString
        {
            return string.Format("{0}, 數量:{1}, 小記:{2}", this.Name, this.Amount, this.Price * this.Amount);
        }

        //public virtual void SaySomething()                            //4.1父類別的SaySomething()
        //{
        //    Console.WriteLine("這是Product類別的SaySomething()");
        //}

        public void SaySomething()                                      //6.2把override、virtual拿掉，試試看anotherCPU是不是改回用Priduct的SaySomething()了
        {
            Console.WriteLine("這是Product類別的SaySomething()");
        }
    }
}