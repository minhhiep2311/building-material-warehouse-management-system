using System;
using System.Collections.Generic;
using System.Linq;
using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Utils;

namespace BTL_LTTQ_QLKhoVLXD.Services
{
    internal class CustomerService
    {
        #region Select

        public static List<Customer> GetAllCustomers()
        {
            const string query =
                "SELECT e.id, e.name, e.address " +
                "FROM customer AS e " +
                "WHERE isAvailable=1 " +
                "ORDER BY e.name";
            var result = DatabaseProvider.Instance.ExecuteQuery(query);
            var employeeList = Helper.Mapper.MapArrayOfObject(result, Customer.FromData);
            return employeeList;
        }

        public static List<string> GetPhoneNumber(int id)
        {
            var query = "SELECT p.phoneNumber FROM customerPhoneNumber AS p " +
                "JOIN customer AS s " +
                "ON s.id=p.idCustomer " +
                $"WHERE s.id={id}";
            var result = DatabaseProvider.Instance.ExecuteQuery(query);
            var phoneList = Helper.Mapper.MapArrayOfObjectProperty(result, "phoneNumber", Convert.ToString);
            return phoneList;
        }

        #endregion

        #region Insert
        public static int CreateCustomer(Customer customer)
        {
            var query = "INSERT INTO supplier " +
                "OUTPUT INSERTED.ID " +
                $"VALUES (N'{customer.Name}', " +
                $"N'{customer.Address}')";

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

        public static bool AddNewPhoneNumbers(Customer customer, List<string> phoneList)
        {
            if (phoneList.Count == 0)
                return true;

            var values = phoneList.Select(phone => $"(N'{customer.Id}', N'{phone}')");
            var query = $"INSERT INTO customerPhoneNumber VALUES {string.Join(", ", values)}";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);
            return rowAffected == phoneList.Count;
        }

        #endregion

        #region Update
        public static bool ChangeCustomerInformation(Customer customer)
        {
            var query = $"UPDATE supplier SET name = N'{customer.Name}', " +
                $"address = N'{customer.Address}', " +
                $"WHERE id = N'{customer.Id}'";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return rowAffected > 0;
        }
        #endregion

        #region Delete

        public static bool DeleteCustomer(List<int> customerIdList)
        {
            var usernameList = string.Join(", ", customerIdList.Select(x => $"N'{x}'"));
            var query = $"UPDATE customer SET isAvailable=0 WHERE id IN ({usernameList})";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return rowAffected == customerIdList.Count;
        }

        public static bool DeletePhoneNumbers(List<string> phoneList)
        {
            if (phoneList.Count == 0)
                return true;

            var query = $"DELETE customerPhoneNumber WHERE phoneNumber IN ({string.Join(", ", phoneList)})";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);
            return rowAffected == phoneList.Count;
        }
        #endregion
    }
}
