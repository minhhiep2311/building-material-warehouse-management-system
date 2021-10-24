using System;
using System.Data;

namespace BTL_LTTQ_QLKhoVLXD.Models
{
    public class User
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public bool IsMale { get; private set; }
        public DateTime Dob { get; private set; }
        public EmployeePosition Position { get; private set; }
        public string Account { get; private set; }

        private User() { }

        public User(string name, string address, bool isMale, DateTime dob, EmployeePosition position, string account)
        {
            Name = name;
            Address = address;
            IsMale = isMale;
            Dob = dob;
            Position = position;
            Account = account;
        }

        public static User FromData(DataRow data)
        {
            return new User
            {
                Name = Convert.ToString(data["name"]),
                Address = Convert.ToString(data["address"]),
                IsMale = Convert.ToInt32(data["isMale"]) == 1,
                Dob = Convert.ToDateTime(data["dob"]),
                Position = new EmployeePosition(data["idPosition"], data["position"]),
                Account = Convert.ToString(data["username"])
            };
        }
    }
}
