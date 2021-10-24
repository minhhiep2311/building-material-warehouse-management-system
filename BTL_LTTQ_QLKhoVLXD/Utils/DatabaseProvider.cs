using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BTL_LTTQ_QLKhoVLXD
{
    class DatabaseProvider
    {
        private static readonly ConnectionStringSettings connectionSettings = ConfigurationManager.ConnectionStrings["default"];

        private static DatabaseProvider instance;
        public static DatabaseProvider Instance
        {
            get => instance ?? (instance = new DatabaseProvider());
            private set => instance = value;
        }

        private DatabaseProvider() { }

        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSettings.ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(connectionSettings.ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                rowsAffected = command.ExecuteNonQuery();
                connection.Close();
            }

            return rowsAffected;
        }

        public object ExecuteScalar(string query)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSettings.ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                data = command.ExecuteScalar();
                connection.Close();
            }

            return data;
        }
    }
}