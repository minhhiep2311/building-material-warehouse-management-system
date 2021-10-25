using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BTL_LTTQ_QLKhoVLXD.Utils
{
    class DatabaseProvider
    {
        private static readonly ConnectionStringSettings ConnectionSettings = ConfigurationManager.ConnectionStrings["default"];

        private static DatabaseProvider _instance;
        public static DatabaseProvider Instance => _instance ?? (_instance = new DatabaseProvider());

        private DatabaseProvider() { }

        public DataTable ExecuteQuery(string query)
        {
            var data = new DataTable();

            using (var connection = new SqlConnection(ConnectionSettings.ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
                var adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query)
        {
            int rowsAffected;

            using (var connection = new SqlConnection(ConnectionSettings.ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
                rowsAffected = command.ExecuteNonQuery();
                connection.Close();
            }

            return rowsAffected;
        }

        public object ExecuteScalar(string query)
        {
            object data;

            using (var connection = new SqlConnection(ConnectionSettings.ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(query, connection);
                data = command.ExecuteScalar();
                connection.Close();
            }

            return data;
        }
    }
}