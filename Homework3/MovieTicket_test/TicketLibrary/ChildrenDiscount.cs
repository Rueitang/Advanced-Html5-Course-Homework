using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicketLibrary
{
    public class ChildrenDiscount : IDiscountBehavior
    {
        protected int isBaby;

        public void TicketKind(int kind)
        {
            isBaby = kind;
        }

        public double Calculate(double price)
        {
            return isBaby == 0 ? price * 0.3 : price * 0.7;
        }
    }
}