using System;
namespace StrategyPattern
{
    public class Ticket
    {

        private IPromotedTicketStategy promotedTicketStategy;
        private string _name;
        private double _price;
        public IPromotedTicketStategy GetpromotedTicketStategy()
        {
            return promotedTicketStategy;
        }

        public void SetpromotedTicketStategy(IPromotedTicketStategy value)
        {
            promotedTicketStategy = value;
        }

        public double GetPrice()
        {
            return _price;
        }

        public void SetPrice(double value)
        {
            _price = value;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string value)
        {
            _name = value;
        }

        public Ticket(IPromotedTicketStategy value)
        {
            promotedTicketStategy = value;
        }

        public Ticket()
        {

        }


        public double GetPromotedPrice() {

            return promotedTicketStategy.DoDiscount(_price);
        }

    }
}
