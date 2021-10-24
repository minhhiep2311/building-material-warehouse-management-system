using BTL_LTTQ_QLKhoVLXD.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace BTL_LTTQ_QLKhoVLXD.Services
{
    static class EmployeeService
    {
        public static List<EmployeePosition> GetPositions()
        {
            string query = "SELECT * FROM employeePosition";
            DataTable data = DatabaseProvider.Instance.ExecuteQuery(query);

            List<EmployeePosition> result = new List<EmployeePosition>();
            foreach (DataRow row in data.Rows)
                result.Add(EmployeePosition.FromData(row));

            return result;
        }

        public static int CreateEmployee(User user)
        {
            string query = $"INSERT INTO employee " +
                $"OUTPUT INSERTED.ID " +
                $"VALUES (N'{user.Name}', " +
                $"N'{user.Address}', " +
                $"{(user.IsMale ? "1" : "0")}, " +
                $"'{user.Dob.ToShortDateString()}', " +
                $"{user.Position.Id})";

            try
            {
                int employeeId = Convert.ToInt32(DatabaseProvider.Instance.ExecuteScalar(query));
                return employeeId;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
