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
        public static List<EmployeePosition> GetPositions()
        {
            const string query = "SELECT * FROM employeePosition";
            var data = DatabaseProvider.Instance.ExecuteQuery(query);

            return (from DataRow row in data.Rows select EmployeePosition.FromData(row)).ToList();
        }

        public static int CreateEmployee(User user)
        {
            var query = $"INSERT INTO employee " +
                        $"OUTPUT INSERTED.ID " +
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
    }
}
