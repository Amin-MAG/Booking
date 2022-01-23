using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Booking.Interfaces;

namespace Booking.Classes.Inventory
{

    public sealed class Inventory
    {
        Inventory() { }
        private static readonly object l = new object();
        
        private static Inventory instance = null;
        public static Inventory Instance
        {
            get
            {
                lock (l)
                {
                    if (instance == null)
                    {
                        instance = new Inventory();
                    }
                    return instance;
                }
            }
        }

        public List<Item> items = new List<Item>();

        public List<Item> getItems()
        {
            return this.items;
        }

        public List<Item> getTypeItems<Type>()
        {
            return items.Where(x => x.GetType() is Type).ToList();
        }

        public List<Item> filter<Type>(Spec spec)
        {
            List<Item> result = new List<Item>();

            foreach (var item in getTypeItems<Type>())
            {
                if (item.itemSpec.matches(spec))
                {
                    result.Add(item);
                }
            }

            return result;

        }


    }


}
