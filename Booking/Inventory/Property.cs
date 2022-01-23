using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Classes
{
    public class Property
    {
        public Dictionary<string, object> properties = new Dictionary<string, object>();

        public bool addProperty(string key, object val)
        {
            try
            {
                this.properties.Add(key, val);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public object getProperty(string key)
        {
            return this.properties[key];
        }

        public Dictionary<string, object> getProperties()
        {
            return properties;
        }

        public bool updateProperty(string key, object val)
        {
            try
            {
                this.properties[key] = val;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool removeProperty(string key)
        {
            try
            {
                this.properties.Remove(key);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

}
