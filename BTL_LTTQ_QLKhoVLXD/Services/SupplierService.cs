using System;
using System.Collections.Generic;
using System.Linq;
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
                "FROM supplier AS e " +
                "WHERE isAvailable=1" +
                "ORDER BY e.name";
            var result = DatabaseProvider.Instance.ExecuteQuery(query);
            var supplierList = Helper.Mapper.MapArrayOfObject(result, Supplier.FromData);
            return supplierList;
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

        #region Insert

        public static int CreateSupplier(Supplier supplier)
        {
            var query = "INSERT INTO supplier(name, address) " +
                "OUTPUT INSERTED.ID " +
                $"VALUES (N'{supplier.Name}', " +
                $"N'{supplier.Address}')";

            try
            {
                var supplierId = Convert.ToInt32(DatabaseProvider.Instance.ExecuteScalar(query));
                return supplierId;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static bool AddNewPhoneNumbers(Supplier supplier, List<string> phoneList)
        {
            if (phoneList.Count == 0)
                return true;

            var values = phoneList.Select(phone => $"(N'{supplier.Id}', N'{phone}')");
            var query = $"INSERT INTO supplierPhoneNumber VALUES {string.Join(", ", values)}";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);
            return rowAffected == phoneList.Count;
        }

        #endregion

        #region Delete

        public static bool DeleteSupplier(List<int> supplierIdList)
        {
            var supplierList = string.Join(", ", supplierIdList.Select(x => $"N'{x}'"));
            var query = $"UPDATE supplier SET isAvailable=0 WHERE id IN ({supplierList})";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return rowAffected == supplierIdList.Count;
        }

        public static bool DeletePhoneNumbers(List<string> phoneList)
        {
            if (phoneList.Count == 0)
                return true;

            var query = $"DELETE supplierPhoneNumber WHERE phoneNumber IN ({string.Join(", ", phoneList)})";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);
            return rowAffected == phoneList.Count;
        }

        #endregion

        #region Update

        public static bool ChangeSupplierInformation(Supplier supplier)
        {
            var query = $"UPDATE supplier SET name = N'{supplier.Name}', " +
                $"address = N'{supplier.Address}' " +
                $"WHERE id = {supplier.Id}";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return rowAffected > 0;
        }

        #endregion
    }
}
