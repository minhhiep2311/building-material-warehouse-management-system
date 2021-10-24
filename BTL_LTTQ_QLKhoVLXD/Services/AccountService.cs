using BTL_LTTQ_QLKhoVLXD.Models;
using System;
using System.Data;

namespace BTL_LTTQ_QLKhoVLXD.Services
{
    static class AccountService
    {
        public static User Auth(string username, string password)
        {
            string query = "SELECT e.name, e.address, e.isMale, e.dob, e.idPosition, p.name AS position, a.username " +
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

        public static bool CheckAccountExists(string username)
        {
            string query = "SELECT COUNT(*) FROM account " +
                $"WHERE username = N'{username}'";
            bool accountExists = Convert.ToInt32(DatabaseProvider.Instance.ExecuteScalar(query)) > 0;

            return accountExists;
        }

        public static bool CreateAccount(User user, string password)
        {
            int newEmployeeId = EmployeeService.CreateEmployee(user);

            if (newEmployeeId != -1)
            {
                string query = $"INSERT INTO account VALUES(N'{user.Account}', " +
                    $"N'{password}', " +
                    $"{newEmployeeId})";
                int rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);

                return rowAffected > 0;
            }

            return false;
        }
    }
}
