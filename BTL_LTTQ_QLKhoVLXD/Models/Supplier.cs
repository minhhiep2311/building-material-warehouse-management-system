using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Services;
using BTL_LTTQ_QLKhoVLXD.Utils;

namespace BTL_LTTQ_QLKhoVLXD.Models
{
    public class Supplier : IEquatable<Supplier>
    {
        #region Properties

        public int Id { get; set; }
        public string Name { get; }
        public string Address { get; }
        public List<string> PhoneNumber { get; }

        #endregion

        #region Constructors

        public Supplier(string name, string address = null, List<string> phoneNumber = null): this(-1 , name, address, phoneNumber) { }

        public Supplier(int id, string name, string address) : this(id, name, address, GetPhoneNumberData(id)) { }

        public Supplier(int id, string name, string address, List<string> phoneNumber)
        {
            Id = id;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        #endregion

        #region Public Methods

        public static Supplier FromData(DataRow data)
        {
            var id = Convert.ToInt32(data["id"]);
            var name = Convert.ToString(data["name"]);
            var address = Convert.ToString(data["address"]);

            return new Supplier(id, name, address);
        }

        public ListViewItem ToListViewItem()
        {
            var row = new ListViewItem(Id.ToString());
            row.SubItems.Add(Name);
            row.SubItems.Add(Address);
            return row;
        }

        #endregion

        #region Private Methods

        private static List<string> GetPhoneNumberData(int id)
        {
            return SupplierService.GetPhoneNumber(id);
        }

        #endregion

        #region Overrides

        public override string ToString()
        {
            return Name;
        }

        public bool Equals(Supplier other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return Name == other.Name &&
                Address == other.Address &&
                Helper.List.AreEqual(PhoneNumber, other.PhoneNumber);
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            if (ReferenceEquals(this, obj))
                return true;

            return obj.GetType() == GetType() && Equals((Supplier)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Name != null ? Name.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ (Address != null ? Address.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (PhoneNumber != null ? PhoneNumber.GetHashCode() : 0);
                return hashCode;
            }
        }

        #endregion
    }
}
