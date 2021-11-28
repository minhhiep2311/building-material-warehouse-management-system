using System;
using System.Collections.Generic;
using System.Data;
using BTL_LTTQ_QLKhoVLXD.Services;

namespace BTL_LTTQ_QLKhoVLXD.Models
{
    public class Warehouse
    {
        #region Properties

        public int Id { get; }
        public string Name { get; }

        public double Area { get; }

        #endregion

        #region Constructor

        public Warehouse(string name) : this(-1, name, 0) { }

        public Warehouse(int id, string name, double area)
        {
            Id = id;
            Name = name;
            Area = area;
        }

        #endregion

        #region Public Methods

        public static Warehouse FromData(DataRow data)
        {
            int id;
            var name = "";
            double area = 0;

            try
            {
                id = Convert.ToInt32(data["id"]);
                name = Convert.ToString(data["name"]);
            }
            catch (Exception)
            {
                return new Warehouse(name);
            }

            try
            {
                area = Convert.ToDouble(data["area"]);
            }
            catch (Exception)
            {
                // ignored
            }

            return new Warehouse(id, name, area);
        }

        public List<Material> GetMaterials()
        {
            return WarehouseService.GetMaterials(this);
        }

        #endregion

        #region Overrides

        public override string ToString()
        {
            return Name;
        }

        #endregion
    }
}
