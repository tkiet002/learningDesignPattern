using System;
namespace StrategyPattern
{
    public class HalfDiscountStategy : IPromotedTicketStategy
    {

        public double DoDiscount(double price)
        {
            return price * 0.5;
        }
    }
}
