using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
    public class MovieTicket
    {
        public IDiscountBehavior discount;

        private double Price;

        public double price;

        public virtual void SetDiscount(IDiscountBehavior discount)
        {
        }

        public void set_Price(double value)
        {
            Price = value * 250;
        }

        public double get_Price()
        {
            return Price;
        }
    }
}