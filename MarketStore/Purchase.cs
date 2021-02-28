using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketStore
{
    public class Purchase
    {        
        private double turnover;
        private double value;
        private double discount;
        private String card;

        //get and set
        public double getValue()
        {
            return value;
        }

        public double getDiscount()
        {
            return discount;
        }

        public String getCard()
        {
            return card;
        }

        public void setTurnover(double turn)
        {
            turnover = turn;
        }

        public void setValue(double val)
        {
            value = val;
        }

        public void setCard(String cd)
        {
            card = cd;
        }

        //Calculate the discount of the order
        public double DiscountCalculation()
        {
            return value * discount/100;
        }

        //Calculate the price with the discount
        public double Total()
        {
            return value - DiscountCalculation();
        }

        //Set the discount rate
        public void SetDiscount()
        {
            switch (card)
            {
                case "Bronze":
                    if (turnover < 100)
                    { discount = 0; }
                    else if (turnover < 300)
                    { discount = 1; }
                    else
                    { discount = 2.5; }
                break;

                case "Silver":
                    if (turnover < 300)
                    { discount = 2; }
                    else
                    { discount = 3.5; }
                break;

                case "Gold":
                    if (turnover >= 800)
                    { discount = 10; }
                    else
                    { discount = 2 + (int)Math.Abs(turnover / 100 % 10); }                    
                break;

                default:
                    discount = 0;
                    card = "not found";
                break;
            }            
        }
    }
}
