using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Services;

namespace BTL_LTTQ_QLKhoVLXD.Models
{
    public class Customer
    {
        #region Properties

        public int Id { get; set; }
        public string Name { get; }
        public string Address { get; }
        public List<string> PhoneNumber { get; }

        #endregion

        #region Constructors
        public Customer(string name, string address, List<string> phoneNumber) : this(-1, name, address, phoneNumber) { }

        public Customer(int id, string name, string address) : this(id, name, address, GetPhoneNumberData(id)) { }

        public Customer(int id, string name, string address, List<string> phoneNumber)
        {
            Id = id;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        #endregion

        #region Public Methods

        public static Customer FromData(DataRow data)
        {
            var id = Convert.ToInt32(data["id"]);
            var name = Convert.ToString(data["name"]);
            var address = Convert.ToString(data["address"]);

            return new Customer(id, name, address);
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
            return CustomerService.GetPhoneNumber(id);
        }

        #endregion
    }
}
