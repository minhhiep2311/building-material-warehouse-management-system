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
            const string query = "SELECT * FROM warehouse";

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
                $"WHERE idWarehouse = {warehouse.Id}";

            var result = DatabaseProvider.Instance.ExecuteQuery(query);
            var materialsList = Helper.Mapper.MapArrayOfObject(result, Material.FromData);
            return materialsList;
        }

        #endregion
    }
}
