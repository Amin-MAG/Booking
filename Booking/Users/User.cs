using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Classes
{
    public class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public float credit { get; set; }

        public Property properties = new Property();

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

    }

}
