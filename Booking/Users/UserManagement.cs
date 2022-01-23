using System;
using System.Collections.Generic;
using System.Text;

namespace Booking.Classes.Users
{
    public sealed class UserManagement
    {
        UserManagement() { }
        private static readonly object l = new object();

        private static UserManagement instance = null;
        public static UserManagement Instance
        {
            get
            {
                lock (l)
                {
                    if (instance == null)
                    {
                        instance = new UserManagement();
                    }
                    return instance;
                }
            }
        }

        public List<Item> users = new List<Item>();

        public List<Item> getItems()
        {
            return this.users;
        }

    }
}
