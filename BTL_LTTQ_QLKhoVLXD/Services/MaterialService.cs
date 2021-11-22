using System;
using System.Collections.Generic;
using System.Linq;
using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Utils;

namespace BTL_LTTQ_QLKhoVLXD.Services
{
    internal static class MaterialService
    {
        #region Select
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
        #endregion
        #region Insert
        public static int CreateMaterial(Material material)
        {
            var query = "INSERT INTO material " +
                "OUTPUT INSERTED.ID " +
                $"VALUES (N'{material.Name}', " +
                $"N'{material.ExportUnitPrice}'," +
                $"N'{material.ImportUnitPrice}'," +
                $"N'{material.Specialization}')";

            try
            {
                var MaterialId = Convert.ToInt32(DatabaseProvider.Instance.ExecuteScalar(query));
                return MaterialId;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        #endregion
        #region Delete
        #endregion
        #region Update
        public static bool ChangeMaterialInformation(Material material)
        {
            var query = $"UPDATE supplier SET name = N'{material.Name}', " +
                $" importUnitPrice = N'{material.ImportUnitPrice}', " +
                $" exportUnitPrice = N'{material.ExportUnitPrice}', " +
                $" specialization = N'{material.Specialization}', " +
                $"WHERE id = N'{material.Id}'";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return rowAffected > 0;
        }
        #endregion

    }
}
