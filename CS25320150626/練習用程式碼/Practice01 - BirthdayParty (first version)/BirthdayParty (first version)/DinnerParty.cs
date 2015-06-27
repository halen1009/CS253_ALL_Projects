using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayParty__first_version_
{
    internal class DinnerParty : Party                  //1.先繼承新開的Party類別
    {
        //public const int CostOfFoodPerPerson = 25;
        //2.1找出一樣的部分，丟到父類別Party裡

        //public int NumberOfPeople { get; set; }
        //2.2找出一樣的部分，丟到父類別Party裡

        //public bool FancyDecorations { get; set; }
        //2.3找出一樣的部分，丟到父類別Party裡

        public bool HealthyOption { get; set; }

        //3.建構式裡也有相同的部分，也可以丟到父類別裡簡化
        //public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        //{
        //    NumberOfPeople = numberOfPeople;
        //    FancyDecorations = fancyDecorations;
        //    HealthyOption = healthyOption;
        //}

        //3.2改建構式
        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption)       //3.1.1原建構式參數不動
            : base(numberOfPeople, fancyDecorations)            //3.1.2把上一行的兩參數傳進父類別的建構式
        {
            //NumberOfPeople = numberOfPeople;
            //FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }

        ////2.4.CalculateCostOfDecorations()其實也一樣，丟進父類別
        //private decimal CalculateCostOfDecorations()
        //{
        //    decimal costOfDecorations;
        //    if (FancyDecorations)
        //    {
        //        costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
        //    }
        //    else
        //    {
        //        costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
        //    }
        //    return costOfDecorations;
        //}

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson;
            if (HealthyOption)
            {
                costOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                costOfBeveragesPerPerson = 20.00M;
            }
            return costOfBeveragesPerPerson;
        }

        ////4.改掉Cost有重複的部分(乘法拆解後: (A+B)*C =  A*C+B*C)
        //public decimal Cost
        //{
        //    get
        //    {
        //        decimal totalCost = CalculateCostOfDecorations();

        //        //4.1拆解有相同的部分
        //        //totalCost += ((CalculateCostOfBeveragesPerPerson()
        //        //                      + CostOfFoodPerPerson) * NumberOfPeople);
        //        //4.2變成
        //        totalCost = CalculateCostOfBeveragesPerPerson()* NumberOfPeople + CostOfFoodPerPerson * NumberOfPeople;

        //        if (HealthyOption)
        //        {
        //            totalCost *= .95M;
        //        }
        //        return totalCost;
        //    }
        //}
        ////5.然後Cost()重複的部分又可以丟到父類別Party裡

        //5.2改Cost，去掉有重複的部分
        override public decimal Cost                   //5.2.1記得加ovverride
        {
            get
            {
                decimal totalCost = base.Cost;      //5.2.2先繼承父類別的Cost()來用

                //5.2.3乘法拆開後剩下的
                totalCost += CalculateCostOfBeveragesPerPerson() * NumberOfPeople;

                //5.2.4其他剩餘部份
                if (HealthyOption)
                {
                    totalCost *= .95M;
                }
                return totalCost;
            }
        }
    }
}