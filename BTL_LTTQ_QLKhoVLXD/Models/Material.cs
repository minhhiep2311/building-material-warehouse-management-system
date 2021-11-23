using System;
using System.Data;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Utils;

namespace BTL_LTTQ_QLKhoVLXD.Models
{
    public class Material
    {
        public enum Type
        {
            Full,
            Import,
            Export
        }

        #region Properties

        public int Id { get; set; }
        public string Name { get; }
        public double ImportUnitPrice { get; set; }
        public double ExportUnitPrice { get; set; }
        public MaterialUnit Unit { get; }
        public string Specialization { get; }
        public int Numerous { get; set; }

        #endregion

        #region Constructor
        public Material(
            string name,
            double importUnitPrice,
            double exportUnitPrice,
            string specialization) :
            this(-1, name, importUnitPrice, exportUnitPrice)
        { }

        public Material(
            int id,
            string name,
            double importUnitPrice,
            double exportUnitPrice,
            MaterialUnit unit = null,
            string specialization = null,
            int numerous = 0)
        {
            Id = id;
            Name = name;
            ImportUnitPrice = importUnitPrice;
            ExportUnitPrice = exportUnitPrice;
            Unit = unit;
            Specialization = specialization;
            Numerous = numerous;
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

            try
            {
                var numerous = Convert.ToInt32(data["amount"]);
                return new Material(id, name, importUnitPrice, exportUnitPrice, unit, specialization, numerous);
            }
            catch (Exception)
            {
                return new Material(id, name, importUnitPrice, exportUnitPrice, unit, specialization);
            }
        }

        public ListViewItem ToListViewItem(Type type = Type.Full)
        {
            var row = new ListViewItem(Id.ToString());

            switch (type)
            {
                case Type.Full:
                    row.SubItems.Add(Name);
                    row.SubItems.Add(Helper.Format.String(ImportUnitPrice));
                    row.SubItems.Add(Helper.Format.String(ExportUnitPrice));
                    row.SubItems.Add(Unit.Name);
                    row.SubItems.Add(Specialization);
                    break;
                case Type.Import:
                    row.SubItems.Add(Name);
                    row.SubItems.Add(Helper.Format.String(ImportUnitPrice));
                    row.SubItems.Add(Numerous.ToString());
                    row.SubItems.Add(Unit.Name);
                    row.SubItems.Add(Specialization);
                    break;
                case Type.Export:
                    row.SubItems.Add(Name);
                    row.SubItems.Add(Helper.Format.String(ExportUnitPrice));
                    row.SubItems.Add(Numerous.ToString());
                    row.SubItems.Add(Unit.Name);
                    row.SubItems.Add(Specialization);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

            return row;
        }



        #endregion

        #region Overrides

        public override string ToString()
        {
            return Name;
        }

        public Material Clone()
        {
            return new Material(Id, Name, ImportUnitPrice, ExportUnitPrice, Unit, Specialization);
        }

        #endregion
    }
}
