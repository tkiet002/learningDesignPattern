using System;

namespace StrategyPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Get Tickets!");
            var random = new Random();
            for (var i = 0; i <= 5; i++)
            {
                var ticket = new Ticket();
                ticket.SetName("Ticket " + i);
                ticket.SetPrice(100d);
                var indexStategy = random.Next(0, 3);
                //switch case
                switch (indexStategy)
                {
                    case 0:
                        ticket.SetpromotedTicketStategy(new NoDiscountStrategy());
                        break;
                    case 1:
                        ticket.SetpromotedTicketStategy(new HalfDiscountStategy());
                        break;
                    default:
                        ticket.SetpromotedTicketStategy(new QuaterDiscountStrategy());
                        break;
                }

                Console.WriteLine(ticket.GetName() + " " + ticket.GetPromotedPrice() + " " + ticket.GetpromotedTicketStategy());


            }
        }
    }
}