using System.Data;

namespace BTL_LTTQ_QLKhoVLXD.Services
{
    static class MaterialService
    {
        public static DataTable GetAll()
        {
            string query =
                "SELECT m.id, m.name, importUnitPrice, exportUnitPrice, u.Name as unitName, specialization " +
                "FROM material as m " +
                "JOIN unit as u ON m.idUnit=u.id";

            return DatabaseProvider.Instance.ExecuteQuery(query);
        }
    }
}
