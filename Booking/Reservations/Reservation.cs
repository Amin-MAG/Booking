using Booking.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Classes
{
    public class Reservation
    {
        public IReservable reservable;
        public User user;
        public int time;
        public int duration;

        public Reservation() { }

        public Reservation(IReservable reservable, User user, int time, int duration)
        {
            this.reservable = reservable;
            this.user = user;
            this.time = time;
            this.duration = duration;
        }

    }

}
