using System.Data;
using System.Data.SqlClient;

namespace BTL_LTTQ_QLKhoVLXD
{
    static class DatabaseProvider
    {
        public static SqlConnection Connection { get; private set; }

        public static void Init()
        {
            string server = "14.225.255.234";
            string database = "btl_lttq";
            string uid = "lttq_account";
            string pwd = "sqlServer00p@ssword,";
            string intergratedSecurity = "false";

            string connectionString = string.Format(
                "Server={0};Database={1};UID={2};PWD={3};Integrated Security={4}",
                server,
                database,
                uid,
                pwd,
                intergratedSecurity
            );

            Connection = new SqlConnection(connectionString);
            Connection.Open();
        }

        public static void Dispose()
        {
            if (Connection.State != ConnectionState.Closed)
                Connection.Close();

            Connection.Dispose();
        }
    }
}