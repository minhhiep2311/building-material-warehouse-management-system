using BTL_LTTQ_QLKhoVLXD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using BTL_LTTQ_QLKhoVLXD.Utils;

namespace BTL_LTTQ_QLKhoVLXD.Services
{
    internal static class AccountService
    {
        #region Select

        public static User Auth(string username, string password)
        {
            var query = "SELECT e.id, e.name, e.address, e.isMale, e.dob, e.idPosition, p.name AS position, a.username " +
                        "FROM account AS a " +
                        "JOIN employee AS e ON e.id=a.idEmployee " +
                        "JOIN employeePosition AS p ON p.id = e.idPosition " +
                        $"WHERE a.username = N'{username}' AND a.password = N'{password}'";
            var result = DatabaseProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0 ? User.FromData(result.Rows[0]) : null;
        }

        public static bool CheckPassword(string username, string password)
        {
            var query = "SELECT COUNT(*) " +
                        "FROM account AS a " +
                        $"WHERE a.username = N'{username}' AND a.password = N'{password}'";
            var accountExists = Convert.ToInt32(DatabaseProvider.Instance.ExecuteScalar(query)) > 0;

            return accountExists;
        }

        public static bool CheckAccountExists(string username)
        {
            var query = "SELECT COUNT(*) FROM account " +
                $"WHERE username = N'{username}'";
            var accountExists = Convert.ToInt32(DatabaseProvider.Instance.ExecuteScalar(query)) > 0;

            return accountExists;
        }

        #endregion

        #region Insert

        public static bool CreateAccount(User user, string password)
        {
            var query = $"INSERT INTO account VALUES(N'{user.Account}', " +
                $"N'{password}', " +
                $"{user.Id})";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return rowAffected > 0;
        }

        #endregion

        #region Update

        public static bool ChangePassword(string username, string password)
        {
            var query = $"UPDATE account SET password=N'{password}' " +
                $"WHERE username = N'{username}'";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return rowAffected > 0;
        }

        #endregion

        #region Delete

        public static bool DeleteAccount(List<string> accountList)
        {
            var usernameList = string.Join(", ", accountList.Select(x => $"N'{x}'"));
            var query = $"DELETE account WHERE username IN ({usernameList})";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return rowAffected == accountList.Count;
        }

        #endregion
    }
}
