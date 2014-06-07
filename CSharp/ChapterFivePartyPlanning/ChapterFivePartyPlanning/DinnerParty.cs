using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterFivePartyPlanning
{
    class DinnerParty
    {
        private int numberOfPeople;
        public int NumberOfPeople { get { return numberOfPeople; } set { numberOfPeople = value;} }
        public decimal CostOfBeveragesPerPerson, CostOfDecorations;
        
        public const int CostOfFoodPerPerson =25;

        public void SetHealthyOption(bool healthyOption)
        {
            if(healthyOption)
            {
                CostOfBeveragesPerPerson = 5.0M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.0M;
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            if(fancy)
            {
                CostOfDecorations = 15M;
            }
            else
            {
                CostOfDecorations = 7.50M;
            }
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);
            if (healthyOption)
            {
                return totalCost * .95M;
            }
            else
            {
                return totalCost;
            }
        }
    }
}
