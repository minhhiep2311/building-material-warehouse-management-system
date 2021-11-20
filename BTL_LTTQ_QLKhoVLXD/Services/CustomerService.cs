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
                "WHERE isAvailable=1";
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

        #region Delete

        public static bool DeleteCustomer(List<int> customerIdList)
        {
            var usernameList = string.Join(", ", customerIdList.Select(x => $"N'{x}'"));
            var query = $"UPDATE customer SET isAvailable=0 WHERE id IN ({usernameList})";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return rowAffected == customerIdList.Count;
        }

        #endregion
    }
}
