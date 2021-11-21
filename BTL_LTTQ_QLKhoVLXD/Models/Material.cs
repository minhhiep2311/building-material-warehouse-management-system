using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace BTL_LTTQ_QLKhoVLXD.Models
{
    public class Material
    {
        #region Properties

        public int Id { get; }
        public string Name { get; }
        public double ImportUnitPrice { get; }
        public double ExportUnitPrice { get; }
        public MaterialUnit Unit { get; }
        public string Specialization { get; }

        #endregion

        #region Constructor

        public Material(int id, string name, double importUnitPrice, double exportUnitPrice, MaterialUnit unit, string specialization)
        {
            Id = id;
            Name = name;
            ImportUnitPrice = importUnitPrice;
            ExportUnitPrice = exportUnitPrice;
            Unit = unit;
            Specialization = specialization;
        }

        #endregion

        #region Public Methods

        public static Material FromData(DataRow data)
        {
            var id = Convert.ToInt32(data["id"]);
            var name = Convert.ToString(data["name"]);
            var importUnitPrice = Convert.ToDouble(data["importUnitPrice"]);
            var exportUnitPrice = Convert.ToDouble(data["exportUnitPrice"]);
            var unit = new MaterialUnit(data["unitId"], data["unitName"]);
            var specialization = Convert.ToString(data["specialization"]);

            return new Material(id, name, importUnitPrice, exportUnitPrice, unit, specialization);
        }

        public ListViewItem ToListViewItem()
        {
            var row = new ListViewItem(Id.ToString());
            row.SubItems.Add(Name);
            row.SubItems.Add(ImportUnitPrice.ToString(CultureInfo.CurrentCulture));
            row.SubItems.Add(ExportUnitPrice.ToString(CultureInfo.CurrentCulture));
            row.SubItems.Add(Unit.Name);
            row.SubItems.Add(Specialization);
            return row;
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
