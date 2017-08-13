using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinnerParty
{
    public class DinnerParty
    {
        public int NumberOfPeople = 0;
        public Decimal CostOfBeveragesPerPerson = 20.0M;
        //Using Decimal to hold currency amount
        public Decimal CostOfDecorations = 7.50M;
        public const int CostOfFoodPerPerson = 25;
        //Using const as this amount never changes, it is constant
        public decimal CostTotal = 0.00M;
        public decimal discount = 0;
        public bool Decorations = false;

        public decimal CalculateCostOfDecoration(bool fancyDecorations)
        {
            //calculate cost of decoarions
            if (fancyDecorations)
            {
                CostOfDecorations = 15.0M;
                Decorations = true;
            }
            else
            {
                CostOfDecorations = 7.50M;
                Decorations = false;
            }
            return CostOfDecorations;
        }

        public void SetHealthyOption(bool healthyOption)
        {
            //set menu to healthy
            if (healthyOption) {
                CostOfBeveragesPerPerson = 5.00M;
                    }
            else
            {
                CostOfBeveragesPerPerson = 20.0M;
            }
        }


        public decimal CalculateCost(bool Decorations, bool healthyOption)
        {
            //calculate overall cost by multiply set Food cost by number of people
            //Use decoration level cost to multply by number of people, add to cost
            //Use beverage choice to multiply by number of people, add to cost

            CostTotal = NumberOfPeople * CostOfFoodPerPerson;
            CostTotal = (NumberOfPeople * CostOfDecorations) + CostTotal;
            CostTotal = (NumberOfPeople * CostOfBeveragesPerPerson) + CostTotal;

            //apply one-time decorating fee to the cost, depending on choice of decor
            if (Decorations == true)
            {
                CostTotal = CostTotal + 50.00M;
            }
            else
            {
                CostTotal = CostTotal + 30.00M;
            }

            //apply the healthyoption discount if selected
            if (healthyOption)
            {
                discount = (CostTotal / 100) * 5;
                CostTotal = CostTotal - discount;
            }
            return CostTotal;
        }





        
    }
}
