using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayParty__first_version_
{
    internal class Party
    {
        //2.把DinnerParty及BirthdayParty共同的變數放進來
        public const int CostOfFoodPerPerson = 25;

        public int NumberOfPeople { get; set; }

        public bool FancyDecorations { get; set; }

        //2.4.CalculateCostOfDecorations()其實也一樣
        protected decimal CalculateCostOfDecorations()          //2.4.1改成protected，否則繼承者不能用
        {
            decimal costOfDecorations;
            if (FancyDecorations)
            {
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
            return costOfDecorations;
        }

        //3.1把子類別建構式裡相同的部分放在Party的建構式裡
        public Party(int numberOfPeople, bool fancyDecorations)     //3.1.1剪下貼上的
        {
            NumberOfPeople = numberOfPeople;                        //3.1.1剪下貼上的
            FancyDecorations = fancyDecorations;
        }

        //5.1取出Cost中相同的3行
        virtual public decimal Cost     //5.1.1注意要加上virtual
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();       //5.1.2重複的三行
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                return totalCost;
            }
        }
    }
}