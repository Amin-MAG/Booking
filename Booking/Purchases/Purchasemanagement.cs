using Booking.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Classes
{
    public class Purchasemanagement
    {
        Purchasemanagement() { }
        private static readonly object l = new object();

        private static Purchasemanagement instance = null;
        public static Purchasemanagement Instance
        {
            get
            {
                lock (l)
                {
                    if (instance == null)
                    {
                        instance = new Purchasemanagement();
                    }
                    return instance;
                }
            }
        }


        public List<Item> items = Inventory.Inventory.Instance.getTypeItems<IPurchasable>();


        public Dictionary<IPurchasable, Purchase?> purchases = new Dictionary<IPurchasable, Purchase?>();

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



        public bool isAvailable(IPurchasable purchasable)
        {
            if (this.purchases[purchasable] == null)
            {
                return true;
            }

            return false;
        }

        public List<Item> filter(Spec spec)
        {
            return Inventory.Inventory.Instance.filter<IPurchasable>(spec);
        }

        public Purchase buy(IPurchasable purchasable, User user, int time)
        {
            if (isAvailable(purchasable))
            {
                Purchase newPurchase = new Purchase(purchasable, user, time);
                this.purchases[purchasable] = newPurchase;
                return newPurchase;
            }
            return null;
        }


    }

}
