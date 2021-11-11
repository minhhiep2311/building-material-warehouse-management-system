using System;
using System.Collections.Generic;
using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Utils;

namespace BTL_LTTQ_QLKhoVLXD.Services
{
    internal class SupplierService
    {
        #region Select

        public static List<Supplier> GetAllSuppliers()
        {
            const string query =
                "SELECT e.id, e.name, e.address " +
                "FROM supplier AS e";
            var result = DatabaseProvider.Instance.ExecuteQuery(query);
            var employeeList = Helper.Mapper.MapArrayOfObject(result, Supplier.FromData);
            return employeeList;
        }

        public static List<string> GetPhoneNumber(int id)
        {
            var query = "SELECT p.phoneNumber FROM supplierPhoneNumber AS p " +
                "JOIN supplier AS s " +
                "ON s.id=p.idSupplier " +
                $"WHERE s.id={id}";
            var result = DatabaseProvider.Instance.ExecuteQuery(query);
            var phoneList = Helper.Mapper.MapArrayOfObjectProperty(result, "phoneNumber", Convert.ToString);
            return phoneList;
        }

        #endregion
    }
}
