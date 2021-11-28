using System;
using System.Collections.Generic;
using System.Data;
using BTL_LTTQ_QLKhoVLXD.Services;
using BTL_LTTQ_QLKhoVLXD.Utils;

namespace BTL_LTTQ_QLKhoVLXD.Models
{
    public class User : IEquatable<User>
    {
        #region Properties

        public int Id { get; set; }
        public string Name { get; }
        public string Address { get; }
        public bool IsMale { get; }
        public DateTime Dob { get; }
        public EmployeePosition Position { get; }
        public string Account { get; set; }
        public List<string> PhoneNumber { get; }
        public HashSet<string> Permissions { get; private set; }

        #endregion

        #region Constructors

        public User(string name, string address = null, bool isMale = default, DateTime dob = default, EmployeePosition position = null, List<string> phoneNumber = null)
            : this(-1, name, address, isMale, dob, position, null, phoneNumber)
        { }

        public User(string name, string address, bool isMale, DateTime dob, EmployeePosition position, string account)
            : this(-1, name, address, isMale, dob, position, account, GetPhoneNumberData(account))
        { }

        public User(int id, string name, string address, bool isMale, DateTime dob, EmployeePosition position, string account)
            : this(id, name, address, isMale, dob, position, account, GetPhoneNumberData(account))
        { }

        public User(int id, string name, string address, bool isMale, DateTime dob, EmployeePosition position, string account, List<string> phoneNumber)
        {
            Id = id;
            Name = name;
            Address = address;
            IsMale = isMale;
            Dob = dob;
            Position = position;
            Account = account;
            PhoneNumber = phoneNumber;
        }

        #endregion

        #region Public Methods

        public static User FromData(DataRow data)
        {
            var id = Convert.ToInt32(data["id"]);
            var account = Convert.ToString(data["username"]);
            var name = Convert.ToString(data["name"]);
            var address = Convert.ToString(data["address"]);
            var isMale = Convert.ToInt32(data["isMale"]) == 1;
            var dob = Convert.ToDateTime(data["dob"]);
            var position = new EmployeePosition(data["idPosition"], data["position"]);

            return new User(id, name, address, isMale, dob, position, account);
        }

        public void GrantPermission()
        {
            Permissions = new HashSet<string>();
            foreach (var permission in typeof(PermissionConstant).GetFields())
            {
                if (permission.GetValue(null) is List<int> list && list.Contains(Position.Id))
                    Permissions.Add(permission.Name);
            }
        }

        #endregion

        #region Private Methods

        private static List<string> GetPhoneNumberData(string account)
        {
            return EmployeeService.GetPhoneNumber(account);
        }

        #endregion

        #region Overrides

        public bool Equals(User other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return Name == other.Name &&
                Address == other.Address &&
                IsMale == other.IsMale &&
                Dob.Equals(other.Dob) &&
                Equals(Position, other.Position) &&
                Account == other.Account &&
                Helper.List.AreEqual(PhoneNumber, other.PhoneNumber);
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
                hashCode = (hashCode * 397) ^ (PhoneNumber != null ? PhoneNumber.GetHashCode() : 0);
                return hashCode;
            }
        }

        #endregion
    }
}
