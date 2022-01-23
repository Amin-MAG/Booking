using Booking.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Classes
{
    public class Spec
    {
        public Property properties = new Property();
        IMatchStrategy matchStrategy { get; set; }

        public bool addProperty(string key, object val)
        {
            return this.properties.addProperty(key, val);
        }

        public object getProperty(string key)
        {
            return this.properties.getProperty(key);
        }

        public bool updateProperty(string key, object val)
        {
            return this.properties.updateProperty(key, val);
        }

        public bool removeProperty(string key)
        {
            return this.properties.removeProperty(key);
        }

        public bool setMatchStrategy(IMatchStrategy matchStrategy)
        {
            try
            {
                this.matchStrategy = matchStrategy;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool matches(Booking.Classes.Spec otherSpec)
        {
            return matchStrategy.matches(otherSpec);
        }
    }

}
