using System;
using System.Data;

namespace BTL_LTTQ_QLKhoVLXD.Models
{
    public class User
    {
        public string Name { get; private set; }
        public string Position { get; private set; }
        public string Account { get; private set; }

        private User() { }

        public User(string name, string position, string account)
        {
            Name = name;
            Position = position;
            Account = account;
        }


        public static User FromData(DataRow data)
        {
            return new User
            {
                Name = Convert.ToString(data["name"]),
                Position = Convert.ToString(data["position"]),
                Account = Convert.ToString(data["username"])
            };
        }
    }
}
