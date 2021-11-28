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
        public static List<MaterialUnit> GetAllUnits()
        {
            const string query = "Select * from Unit";
            var result = DatabaseProvider.Instance.ExecuteQuery(query);
            var unitList = Helper.Mapper.MapArrayOfObject(result, MaterialUnit.FromData);
            return unitList;
        }
    }
}
