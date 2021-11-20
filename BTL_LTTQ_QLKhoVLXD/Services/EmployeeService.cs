using BTL_LTTQ_QLKhoVLXD.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using BTL_LTTQ_QLKhoVLXD.Utils;

namespace BTL_LTTQ_QLKhoVLXD.Services
{
    internal static class EmployeeService
    {
        #region Select

        public static List<User> GetAllEmployees()
        {
            const string query = "SELECT e.id, a.username, e.name, e.address, e.isMale, e.dob, e.idPosition, p.name AS position " +
                "FROM employee AS e " +
                "JOIN employeePosition AS p ON " +
                "p.id = e.idPosition " +
                "LEFT JOIN account AS a ON " +
                "a.idEmployee = e.id";
            var result = DatabaseProvider.Instance.ExecuteQuery(query);
            var employeeList = Helper.Mapper.MapArrayOfObject(result, User.FromData);

            return employeeList;
        }

        public static List<EmployeePosition> GetPositions()
        {
            const string query = "SELECT * FROM employeePosition";
            var result = DatabaseProvider.Instance.ExecuteQuery(query);
            var positionList = Helper.Mapper.MapArrayOfObject(result, EmployeePosition.FromData);
            return positionList;
        }

        public static List<string> GetPhoneNumber(string username)
        {
            var query = "SELECT p.phoneNumber FROM employeePhoneNumber AS p " +
                "JOIN employee AS e " +
                "ON e.id=p.idEmployee " +
                "JOIN account AS a ON " +
                "a.idEmployee=e.id " +
                $"WHERE a.username=N'{username}'";
            var result = DatabaseProvider.Instance.ExecuteQuery(query);
            var phoneList = Helper.Mapper.MapArrayOfObjectProperty(result, "phoneNumber", Convert.ToString);

            return phoneList;
        }

        #endregion

        #region Insert

        public static int CreateEmployee(User user)
        {
            var query = "INSERT INTO employee " +
                "OUTPUT INSERTED.ID " +
                $"VALUES (N'{user.Name}', " +
                $"N'{user.Address}', " +
                $"{(user.IsMale ? "1" : "0")}, " +
                $"'{user.Dob.ToShortDateString()}', " +
                $"{user.Position.Id})";

            try
            {
                var employeeId = Convert.ToInt32(DatabaseProvider.Instance.ExecuteScalar(query));
                return employeeId;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static bool AddNewPhoneNumbers(User user, List<string> phoneList)
        {
            if (phoneList.Count == 0)
                return true;

            var values = phoneList.Select(phone => $"(N'{user.Id}', N'{phone}')");
            var query = $"INSERT INTO employeePhoneNumber VALUES {string.Join(", ", values)}";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);
            return rowAffected == phoneList.Count;
        }

        #endregion

        #region Update

        public static bool ChangePersonalInformation(User user)
        {
            var query = $"UPDATE employee SET address = N'{user.Address}' " +
                $"WHERE id = N'{user.Id}'";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return rowAffected > 0;
        }

        public static bool ChangeEmployeeInformation(User user)
        {
            var query = $"UPDATE employee SET name = N'{user.Name}', " +
                $"address = N'{user.Address}', " +
                $"isMale = {(user.IsMale ? 1 : 0)}, " +
                $"dob = '{user.Dob.ToShortDateString()}', " +
                $"idPosition = {user.Position.Id} " +
                $"WHERE id = N'{user.Id}'";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return rowAffected > 0;
        }

        #endregion

        #region Delete

        public static bool DeletePhoneNumbers(List<string> phoneList)
        {
            if (phoneList.Count == 0)
                return true;

            var query = $"DELETE employeePhoneNumber WHERE phoneNumber IN ({string.Join(", ", phoneList)})";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);
            return rowAffected == phoneList.Count;
        }

        public static void DeletePhoneNumbers(List<User> userList)
        {
            if (userList.Count == 0)
                return;

            var ids = userList.Select(x => x.Id);
            var query = $"DELETE employeePhoneNumber WHERE idEmployee IN ({string.Join(", ", ids)})";
            DatabaseProvider.Instance.ExecuteNonQuery(query);
        }

        public static bool DeleteEmployee(List<User> employeeList)
        {
            DeletePhoneNumbers(employeeList);

            var idList = string.Join(", ", employeeList.Select(x => x.Id));
            var query = $"DELETE employee WHERE id IN ({idList})";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return rowAffected == employeeList.Count;
        }

        #endregion
    }
}
