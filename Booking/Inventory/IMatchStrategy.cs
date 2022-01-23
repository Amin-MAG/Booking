using Booking.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Interfaces
{
    public interface IMatchStrategy
    {
        public bool matches(Spec spec);
    }

}
