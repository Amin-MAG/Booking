using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Classes
{
    public class AttractionManagement
    {
        AttractionManagement() { }
        private static readonly object l = new object();
        private static AttractionManagement instance = null;
        
        public static AttractionManagement Instance
        {
            get
            {
                lock (l)
                {
                    if (instance == null)
                    {
                        instance = new AttractionManagement();
                    }
                    return instance;
                }
            }
        }

        public List<Item> attractions = Inventory.Inventory.Instance.getTypeItems<Attraction>();

        public List<Item> filter(Spec spec)
        {
            return Inventory.Inventory.Instance.filter<Attraction>(spec);
        }

    }

}
