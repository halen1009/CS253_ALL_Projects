using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example02
{
    internal class Position
    {
        //public float x;
        //public float y;
        //1.1包成類別Position

        //9 把x, y隱藏起來
        private float x;

        private float y;

        //9.1 把位置給封裝起來(x, y要照規定修改)，第一種方式Getter/ Setter
        //(JAVA可針對每個欄位自動產生Getter、Setter)
        //x的Getter/ Setter
        public void SetX(float value)
        {
            if (value <= -200)
                this.x = -200;
            if (value >= 200)
                this.x = 200;
            else this.x = value;
        }

        public float GetX()
        {
            return this.x;
        }

        ////9.2因為永遠內容都一樣，所以微軟用內建方法包起來：改用屬性方式寫(名稱用大寫的欄位名稱)
        public float Y
        {
            set
            {
                if (value <= -200)
                    this.y = -200;
                if (value >= 200)
                    this.y = 200;
                else this.y = value;
            }
            get { return this.y; }
        }

        //9.1再去修改程式中其他內容

        ////9.2因為永遠內容都一樣，所以微軟用內建方法包起來：用屬性方式改(大寫)
        //public float x
        //{
        //    get { return this.x; }
        //    set                             //9.3.1注意set是內建公式，傳入值就是關鍵字value
        //    {
        //        if (value <= -200)
        //        this.x = -200;
        //    if (value >= 200)
        //        this.x = 200;
        //    }
        //}

        //public float y
        //{
        //    get { return this.y; }
        //    set                             //9.3.1注意set是內建公式，傳入值就是關鍵字value
        //    {
        //        if (value <= -200)
        //            this.y = -200;
        //        if (value >= 200)
        //            this.y = 200;
        //    }
        //}

        //9.3更快的封裝方法：在欄位上按右鍵-重購-封裝欄位(變大寫)、或Ctrl + R + E
    }
}