using System;
using System.Collections.Generic;
using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Utils;

namespace BTL_LTTQ_QLKhoVLXD.Services
{
    internal class WarehouseService
    {
        #region Select

        public static List<Warehouse> GetAllWarehouses()
        {
            const string query = "SELECT * FROM warehouse ORDER BY name";

            var result = DatabaseProvider.Instance.ExecuteQuery(query);
            var warehousesList = Helper.Mapper.MapArrayOfObject(result, Warehouse.FromData);
            return warehousesList;
        }

        public static List<Material> GetMaterials(Warehouse warehouse)
        {
            var query = "SELECT m.id, m.name, importUnitPrice, exportUnitPrice, specialization, amount, " +
                "u.id AS unitId, u.name AS unitName " +
                "FROM material_warehouse " +
                "JOIN material m ON material_warehouse.idMaterial = m.id " +
                "JOIN unit u ON m.idUnit = u.id " +
                $"WHERE idWarehouse = {warehouse.Id}" +
                "ORDER BY m.name";

            var result = DatabaseProvider.Instance.ExecuteQuery(query);
            var materialsList = Helper.Mapper.MapArrayOfObject(result, Material.FromData);
            return materialsList;
        }

        public static bool CheckExists(Warehouse warehouse)
        {
            var query = $"SELECT COUNT(*) FROM warehouse WHERE name=N'{warehouse.Name}'";
            var warehouseExisted = Convert.ToInt32(DatabaseProvider.Instance.ExecuteScalar(query)) > 0;

            return warehouseExisted;
        }

        #endregion

        #region Insert

        public static bool Create(Warehouse warehouse)
        {
            var query = $"INSERT INTO warehouse(name, area) VALUES (N'{warehouse.Name}', {warehouse.Area})";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return rowAffected > 0;
        }

        #endregion
    }
}
