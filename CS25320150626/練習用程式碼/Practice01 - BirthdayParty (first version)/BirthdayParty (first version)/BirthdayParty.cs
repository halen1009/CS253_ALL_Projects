using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayParty__first_version_
{
    internal class BirthdayParty : Party                //1.都先繼承新開的Party類別
    {
        //public const int CostOfFoodPerPerson = 25;
        //2.1找出一樣的部分，丟到父類別Party裡

        //public int NumberOfPeople { get; set; }
        //2.2找出一樣的部分，丟到父類別Party裡

        //public bool FancyDecorations { get; set; }
        //2.3找出一樣的部分，丟到父類別Party裡

        public string CakeWriting { get; set; }

        //3.建構式裡也有相同的部分，也可以丟到父類別裡簡化
        //public BirthdayParty(int numberOfPeople,
        //                        bool fancyDecorations, string cakeWriting)
        //{
        //    NumberOfPeople = numberOfPeople;
        //    FancyDecorations = fancyDecorations;
        //    CakeWriting = cakeWriting;
        //}

        //3.2改建構式
        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)         //3.1.1原建構式參數不動
            : base(numberOfPeople, fancyDecorations)        //3.1.2把上一行的兩參數傳進父類別的建構式
        {
            //NumberOfPeople = numberOfPeople;
            //FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }

        private int ActualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return MaxWritingLength();
                else
                    return CakeWriting.Length;
            }
        }

        private int CakeSize()
        {
            if (NumberOfPeople <= 4)
                return 8;
            else
                return 16;
        }

        private int MaxWritingLength()
        {
            if (CakeSize() == 8)
                return 16;
            else
                return 40;
        }

        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                    return true;
                else
                    return false;
            }
        }

        ////2.4.CalculateCostOfDecorations()其實也一樣，丟進父類別
        //private decimal CalculateCostOfDecorations()
        //{
        //    decimal costOfDecorations;
        //    if (FancyDecorations)
        //        costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
        //    else
        //        costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
        //    return costOfDecorations;
        //}

        ////5.把重複部分丟到父類別裡
        //public decimal Cost
        //{
        //    get
        //    {
        //        decimal totalCost = CalculateCostOfDecorations();
        //        totalCost += CostOfFoodPerPerson * NumberOfPeople;
        //        decimal cakeCost;
        //        if (CakeSize() == 8)
        //            cakeCost = 40M + ActualLength * .25M;
        //        else
        //            cakeCost = 75M + ActualLength * .25M;
        //        return totalCost + cakeCost;
        //    }
        //}

        //5.2改Cost，去掉有重複的部分
        public override decimal Cost                   //5.2.1記得加ovverride
        {
            get
            {
                decimal totalCost = base.Cost;      //5.2.2先繼承父類別的Cost()來用

                //5.2.3其他剩餘部份
                decimal cakeCost;
                if (CakeSize() == 8)
                    cakeCost = 40M + ActualLength * .25M;
                else
                    cakeCost = 75M + ActualLength * .25M;
                return totalCost + cakeCost;
            }
        }
    }
}