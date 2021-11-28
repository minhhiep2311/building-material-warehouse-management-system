using System;
using System.Collections.Generic;
using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Utils;

namespace BTL_LTTQ_QLKhoVLXD.Services
{
    internal static class MaterialService
    {
        #region Select

        public static List<Material> GetAllMaterials()
        {
            const string query =
                "SELECT m.id, m.name, importUnitPrice, exportUnitPrice, u.id AS unitId, u.Name AS unitName, specialization, amount, isAvailable " +
                "FROM material AS m " +
                "JOIN unit AS u ON m.idUnit = u.id " +
                "JOIN (SELECT id, ISNULL(SUM(amount), 0) as amount " +
                "FROM material " +
                "LEFT JOIN material_warehouse mw ON material.id = mw.idMaterial " +
                "GROUP BY id) " +
                "AS t ON t.id=m.id " +
                "ORDER BY m.name";

            var result = DatabaseProvider.Instance.ExecuteQuery(query);
            var materialList = Helper.Mapper.MapArrayOfObject(result, Material.FromData);
            return materialList;
        }

        public static List<MaterialWarehouse> GetMaterialInWarehouses(Material material)
        {
            var query = "SELECT idWarehouse AS id, name, amount " +
                "FROM material_warehouse " +
                "JOIN warehouse w ON material_warehouse.idWarehouse = w.id " +
                $"WHERE idMaterial = {material.Id} AND amount > 0";

            var result = DatabaseProvider.Instance.ExecuteQuery(query);
            var materialWarehouseList = Helper.Mapper.MapArrayOfObject(result, MaterialWarehouse.FromData);
            return materialWarehouseList;
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
                var materialId = Convert.ToInt32(DatabaseProvider.Instance.ExecuteScalar(query));
                return materialId;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        #endregion

        #region Update

        public static bool ChangeMaterialInformation(Material material)
        {
            var query = "UPDATE material SET " +
                $"importUnitPrice = {material.ImportUnitPrice}, " +
                $"exportUnitPrice = {material.ExportUnitPrice} " +
                $"WHERE id = {material.Id}";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return rowAffected > 0;
        }

        public static bool DeleteMaterial(List<int> shouldDeleteMaterialIds)
        {
            var materialList = string.Join(", ", shouldDeleteMaterialIds);
            var query = "UPDATE material SET isAvailable = 0 " +
                $"WHERE id IN ({materialList})";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return rowAffected > 0;
        }

        #endregion
    }
}
