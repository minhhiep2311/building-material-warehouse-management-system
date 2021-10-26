using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using BTL_LTTQ_QLKhoVLXD.Services;

namespace BTL_LTTQ_QLKhoVLXD.Models
{
    public class User : IEquatable<User>
    {
        public string Name { get; }
        public string Address { get; }
        public bool IsMale { get; }
        public DateTime Dob { get; }
        public EmployeePosition Position { get; }
        public string Account { get; }
        public List<string> PhoneNumber { get; }

        public User(string name, string address, bool isMale, DateTime dob, EmployeePosition position, string account)
        {
            Name = name;
            Address = address;
            IsMale = isMale;
            Dob = dob;
            Position = position;
            Account = account;
            PhoneNumber = GetPhoneNumberData(account);
        }

        public static User FromData(DataRow data)
        {
            var account = Convert.ToString(data["username"]);
            return new User(
                Convert.ToString(data["name"]),
                Convert.ToString(data["address"]),
                Convert.ToInt32(data["isMale"]) == 1,
                Convert.ToDateTime(data["dob"]),
                new EmployeePosition(data["idPosition"], data["position"]),
                account
            );
        }

        private static List<string> GetPhoneNumberData(string account)
        {
            return AccountService.GetPhoneNumber(account);
        }

        public bool Equals(User other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;

            var firstNotSecond = PhoneNumber.Except(other.PhoneNumber).ToList();
            var secondNotFirst = other.PhoneNumber.Except(PhoneNumber).ToList();
            var phoneNumberListIsEqual = !firstNotSecond.Any() && !secondNotFirst.Any();

            return Name == other.Name &&
                Address == other.Address &&
                IsMale == other.IsMale &&
                Dob.Equals(other.Dob) &&
                Equals(Position, other.Position) &&
                Account == other.Account &&
                phoneNumberListIsEqual;
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            if (ReferenceEquals(this, obj))
                return true;

            return obj.GetType() == GetType() && Equals((User)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Name != null ? Name.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (Address != null ? Address.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ IsMale.GetHashCode();
                hashCode = (hashCode * 397) ^ Dob.GetHashCode();
                hashCode = (hashCode * 397) ^ (Position != null ? Position.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Account != null ? Account.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (PhoneNumber != null ? PhoneNumber.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
