using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicketLibrary
{
    public class VIPDiscount : IDiscountBehavior
    {
        public void TicketKind(int kind)
        { }

        public double Calculate(double price)
        {
            return price * 0.5;
        }
    }
}