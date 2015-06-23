using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example02
{
    internal class Person
    {
        public String name;                                //Person類別裡的第一個欄位：name，是字串
        //public float positionX;
        //public float positionY;
        //1.為了不想把位置分兩個變數，改用類別position包起來

        //1.2使用新增的類別
        public Position position;                          //Person類別裡得第二個欄位：position，是個更小的類別

        //3.與類別同名的方法，叫作建構式
        //3.1建構式不可有回傳值，連void都不行
        public Person()                                    //Person()是Person的建構子，用來初始化
        {
            this.position = new Position();                 //宣告了類別後，要給初始值，用new Position()
            //3.2只要是宣告類別，都是用new，要new了才可以用
        }

        //2.加入向前移動的功能
        public Position Moveforward(float dx)                  //Moveforward()是Person類別裡的一個方法
        {                                                      //用this.position來修改person類別裡的position裡的資料x, y
            //this.position.x += dx;                             //並且以類別position的方式回傳出x, y的值
            //9.1封裝後改成
            this.position.SetX(this.position.GetX() + dx);      //????????????待確認
            return this.position;
        }
    }
}