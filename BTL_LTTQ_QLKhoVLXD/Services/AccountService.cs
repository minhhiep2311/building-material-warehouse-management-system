using BTL_LTTQ_QLKhoVLXD.Models;
using System;
using System.Data;

namespace BTL_LTTQ_QLKhoVLXD.Services
{
    static class AccountService
    {
        public static User Auth(string username, string password)
        {
            string query = "SELECT e.name, p.name AS position, a.username " +
                "FROM account AS a " +
                "JOIN employee AS e ON e.id=a.idEmployee " +
                "JOIN employeePosition AS p ON p.id = e.idPosition " +
                $"WHERE a.username = N'{username}' AND a.password = N'{password}'";
            DataTable result = DatabaseProvider.Instance.ExecuteQuery(query);

            if (result.Rows.Count > 0)
                return User.FromData(result.Rows[0]);

            return null;
        }

        public static bool CheckPassword(string username, string password)
        {
            string query = "SELECT COUNT(*) " +
                "FROM account AS a " +
                $"WHERE a.username = N'{username}' AND a.password = N'{password}'";
            bool accountExists = Convert.ToInt32(DatabaseProvider.Instance.ExecuteScalar(query)) > 0;

            return accountExists;
        }

        public static bool ChangePassword(string username, string password)
        {
            string query = $"UPDATE account SET password=N'{password}' " +
                $"WHERE username = N'{username}'";
            int rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return rowAffected > 0;
        }
    }
}
