using System;
using System.Collections.Generic;
using System.Data;
using BTL_LTTQ_QLKhoVLXD.Services;

namespace BTL_LTTQ_QLKhoVLXD.Models
{
    public class Supplier
    {
        #region Properties

        public int Id { get; set; }
        public string Name { get; }
        public string Address { get; }
        public List<string> PhoneNumber { get; }

        #endregion

        #region Constructors

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

        #endregion

        #region Private Methods

        private static List<string> GetPhoneNumberData(int id)
        {
            return SupplierService.GetPhoneNumber(id);
        }

        #endregion
    }
}
