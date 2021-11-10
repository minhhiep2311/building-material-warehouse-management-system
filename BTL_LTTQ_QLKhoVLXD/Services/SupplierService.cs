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

            var employeeList = new List<Supplier>();
            for (var i = 0; i < result.Rows.Count; i++)
                employeeList.Add(Supplier.FromData(result.Rows[i]));

            return employeeList;
        }

        public static List<string> GetPhoneNumber(int id)
        {
            var query = "SELECT p.phoneNumber FROM supplierPhoneNumber AS p " +
                "JOIN supplier AS s " +
                "ON s.id=p.idSupplier " +
                $"WHERE s.id={id}";
            var result = DatabaseProvider.Instance.ExecuteQuery(query);

            var phoneList = new List<string>();
            for (var i = 0; i < result.Rows.Count; i++)
                phoneList.Add(Convert.ToString(result.Rows[i]["phoneNumber"]));

            return phoneList;
        }

        #endregion
    }
}
