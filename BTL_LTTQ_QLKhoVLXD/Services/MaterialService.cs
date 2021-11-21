using System.Collections.Generic;
using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Utils;

namespace BTL_LTTQ_QLKhoVLXD.Services
{
    internal static class MaterialService
    {
        public static List<Material> GetAllMaterials()
        {
            const string query = "SELECT m.id, " +
                                 "m.name, " +
                                 "importUnitPrice, " +
                                 "exportUnitPrice, " +
                                 "u.id AS unitId, " +
                                 "u.Name AS unitName, " +
                                 "specialization " +
                                 "FROM material AS m " +
                                 "JOIN unit AS u ON m.idUnit=u.id";

            var result = DatabaseProvider.Instance.ExecuteQuery(query);
            var materialList = Helper.Mapper.MapArrayOfObject(result, Material.FromData);
            return materialList;
        }
    }
}
