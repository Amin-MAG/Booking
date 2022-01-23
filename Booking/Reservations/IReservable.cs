using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Interfaces
{
    public interface IReservable
    {
        public float calculatePrice(int duration);
    }
}
