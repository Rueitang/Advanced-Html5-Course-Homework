using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketLibrary
{
    public interface IDiscountBehavior
    {
        double Calculate(double price);

        void TicketKind(int kind);
    }
}