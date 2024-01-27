using System;
namespace StrategyPattern
{
    public class QuaterDiscountStrategy : IPromotedTicketStategy
    {

        public double DoDiscount(double price)
        {
            return price * 0.75;
        }
    }
}
