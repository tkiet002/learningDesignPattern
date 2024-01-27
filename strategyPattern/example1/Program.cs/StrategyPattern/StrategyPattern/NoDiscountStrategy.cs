using System;
namespace StrategyPattern
{
    public class NoDiscountStrategy : IPromotedTicketStategy
    {

        public double DoDiscount(double price)
        {
            return price;
        }
    }
}
