using System.Data;
using BTL_LTTQ_QLKhoVLXD.Utils;

namespace BTL_LTTQ_QLKhoVLXD.Services
{
    internal static class MaterialService
    {
        public static DataTable GetAll()
        {
            const string query = "SELECT m.id AS N'Mã', " +
                                 "m.name AS N'Tên vật liệu', " +
                                 "importUnitPrice AS N'Đơn giá nhập', " +
                                 "exportUnitPrice AS N'Đơn giá xuất', " +
                                 "u.Name AS N'Đơn vị tính', " +
                                 "specialization AS N'Quy cách'" +
                                 "FROM material AS m " +
                                 "JOIN unit AS u ON m.idUnit=u.id";

            return DatabaseProvider.Instance.ExecuteQuery(query);
        }
    }
}
