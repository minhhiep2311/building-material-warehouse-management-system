using BTL_LTTQ_QLKhoVLXD.Models;
using BTL_LTTQ_QLKhoVLXD.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_LTTQ_QLKhoVLXD.Services
{
    class UnitService
    {
        #region Select
        public static List<MaterialUnit> GetAllUnits()
        {
            const string query = "Select * from Unit";
            var result = DatabaseProvider.Instance.ExecuteQuery(query);
            var unitList = Helper.Mapper.MapArrayOfObject(result, MaterialUnit.FromData);
            return unitList;
        }

        public static bool CheckUnitExists(string unit)
        {
            var query = "SELECT COUNT(*) FROM unit " +
                $"WHERE name = N'{unit}'";
            var accountExists = Convert.ToInt32(DatabaseProvider.Instance.ExecuteScalar(query)) > 0;

            return accountExists;
        }
        #endregion

        #region Insert
        public static bool AddUnit(string materialUnit)
        {
            var query = $"INSERT INTO unit VALUES(N'{materialUnit}')";
            var rowAffected = DatabaseProvider.Instance.ExecuteNonQuery(query);

            return rowAffected > 0;
        }
        #endregion

    }
}
