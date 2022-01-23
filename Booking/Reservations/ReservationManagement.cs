using Booking.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Classes
{

    public class ReservationManagement
    {
        ReservationManagement() { }
        private static readonly object l = new object();

        private static ReservationManagement instance = null;
        public static ReservationManagement Instance
        {
            get
            {
                lock (l)
                {
                    if (instance == null)
                    {
                        instance = new ReservationManagement();
                    }
                    return instance;
                }
            }
        }

        public List<Item> items = Inventory.Inventory.Instance.getTypeItems<IReservable>();

        public Dictionary<IReservable, List<Reservation>> reservations = new Dictionary<IReservable, List<Reservation>>();

        public bool checkCollision(Reservation reservation, int start, int end)
        {
            return ((reservation.time < start) && ((reservation.time + reservation.duration) > start))
                    ||
                    ((reservation.time < end) && ((reservation.time + reservation.duration) > end))
                    ||
                    ((start < reservation.time) && ((reservation.time + reservation.duration) < end));
        }

        public bool isAvailable(IReservable reservable, int time, int duration)
        {
            int start = time;
            int end = start + duration;
            bool flag = true;

            foreach (var reservation in this.reservations[reservable])
            {
                if (checkCollision(reservation, start, end))
                {
                    flag = false;
                }
            }

            return flag;

        }

        public bool addItem(Item item)
        {
            try
            {
                items.Add(item);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool removeItem(Item item)
        {
            try
            {
                items.Remove(item);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Item> GetItems()
        {
            return this.items;
        }

        public List<Item> filter(Spec spec)
        {
            return Inventory.Inventory.Instance.filter<IReservable>(spec);
        }

        public Reservation reserve(IReservable reservable, User user, int time, int duration)
        {
            if (isAvailable(reservable, time, duration))
            {
                Reservation newReservation = new Reservation(reservable, user, time, duration);
                this.reservations[reservable].Add(newReservation);
                return newReservation;
            }
            return null;
        }
    }
}
