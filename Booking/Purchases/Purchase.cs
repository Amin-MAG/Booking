using Booking.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Classes
{
    public class Purchase
    {
        public IPurchasable purchasable;
        public User user;
        public int time;

        public Purchase() { }

        public Purchase(IPurchasable purchasable, User user, int time)
        {
            this.purchasable = purchasable;
            this.user = user;
            this.time = time;
        }
    }

}
