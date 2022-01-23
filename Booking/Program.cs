using Booking.Classes;
using Booking.Interfaces;
using System;
using System.Collections.Generic;

namespace Booking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }




    #region Items
    public class Car : Item, IReservable
    {
        public float calculatePrice(int duration)
        {
            throw new NotImplementedException();
        }
    }

    public class Place : Item, IReservable
    {
        public float calculatePrice(int duration)
        {
            throw new NotImplementedException();
        }
    }

    public class Ticket : Item, IPurchasable
    {
        public float getPrice()
        {
            throw new NotImplementedException();
        }
    }
    #endregion Items


    #region Strategies
    public class RestaurantMatchStrategy : IMatchStrategy
    {
        public bool matches(Spec spec)
        {
            throw new NotImplementedException();
        }
    }

    public class CafeMatchStrategy : IMatchStrategy
    {
        public bool matches(Spec spec)
        {
            throw new NotImplementedException();
        }
    }

    public class MuseumMatchStrategy : IMatchStrategy
    {
        public bool matches(Spec spec)
        {
            throw new NotImplementedException();
        }
    }

    public class PlaceMatchStrategy : IMatchStrategy
    {
        public bool matches(Spec spec)
        {
            throw new NotImplementedException();
        }
    }

    public class CarMatchStrategy : IMatchStrategy
    {
        public bool matches(Spec spec)
        {
            throw new NotImplementedException();
        }
    }

    public class FlightMatchStrategy : IMatchStrategy
    {
        public bool matches(Spec spec)
        {
            throw new NotImplementedException();
        }
    }

    #endregion Strategies

}
