using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Services;
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
        public double ExportUnitPrice { get; }
        public MaterialUnit Unit { get; }
        public string Specialization { get; }
        public int Numerous { get; set; }
        public bool IsAvailable { get; }

        #endregion

        #region Constructor

        private Material(
            int id,
            string name,
            double exportUnitPrice,
            string specialization,
            MaterialUnit unit,
            int numerous) :
            this(id, name, 0, exportUnitPrice, specialization, true, unit, numerous)
        { }

        public Material(
            string name,
            double importUnitPrice,
            double exportUnitPrice,
            string specialization,
            bool isAvailable = true) :
            this(-1, name, importUnitPrice, exportUnitPrice, specialization, isAvailable)
        { }

        public Material(
            int id,
            string name,
            double importUnitPrice,
            double exportUnitPrice,
            string specialization = null,
            bool isAvailable = true,
            MaterialUnit unit = null,
            int numerous = 0)
        {
            Id = id;
            Name = name;
            ImportUnitPrice = importUnitPrice;
            ExportUnitPrice = exportUnitPrice;
            IsAvailable = isAvailable;
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
            var isAvailable = Convert.ToInt32(data["isAvailable"]) == 1;
            var unit = new MaterialUnit(data["unitId"], data["unitName"]);
            var specialization = Convert.ToString(data["specialization"]);
            var numerous = Convert.ToInt32(data["amount"]);
            return new Material(id, name, importUnitPrice, exportUnitPrice, specialization, isAvailable, unit, numerous);
        }

        public static Material FromExportReceipt(DataRow data)
        {
            var id = Convert.ToInt32(data["id"]);
            var name = Convert.ToString(data["name"]);
            var unit = new MaterialUnit(data["unitName"]);
            var specialization = Convert.ToString(data["specialization"]);
            var numerous = Convert.ToInt32(data["numerous"]);
            var unitPrice = Convert.ToDouble(data["unitPrice"]);
            return new Material(id, name, unitPrice, specialization, unit, numerous);
        }

        public ListViewItem ToListViewItem(Type type = Type.Full)
        {
            var row = new ListViewItem(Id.ToString());

            switch (type)
            {
                case Type.Full:
                    row.SubItems.Add(Name);
                    row.SubItems.Add(Helper.Converter.ToString(ImportUnitPrice));
                    row.SubItems.Add(Helper.Converter.ToString(ExportUnitPrice));
                    row.SubItems.Add(Unit.Name);
                    row.SubItems.Add(Specialization);
                    break;
                case Type.Import:
                    row.SubItems.Add(Name);
                    row.SubItems.Add(Helper.Converter.ToString(ImportUnitPrice));
                    row.SubItems.Add(Numerous.ToString());
                    row.SubItems.Add(Unit.Name);
                    row.SubItems.Add(Specialization);
                    break;
                case Type.Export:
                    row.SubItems.Add(Name);
                    row.SubItems.Add(Helper.Converter.ToString(ExportUnitPrice));
                    row.SubItems.Add(Numerous.ToString());
                    row.SubItems.Add(Unit.Name);
                    row.SubItems.Add(Specialization);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

            return row;
        }

        public List<MaterialWarehouse> GetMaterialInWarehouses()
        {
            return MaterialService.GetMaterialInWarehouses(this);
        }

        #endregion

        #region Overrides

        public override string ToString()
        {
            return Name;
        }

        public Material Clone()
        {
            return new Material(Id, Name, ImportUnitPrice, ExportUnitPrice, Specialization, true, Unit);
        }

        public bool Equals(Material other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return Name == other.Name &&
                Math.Abs(ImportUnitPrice - other.ImportUnitPrice) < 0.005 &&
                Math.Abs(ExportUnitPrice - other.ExportUnitPrice) < 0.005;
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            if (ReferenceEquals(this, obj))
                return true;

            return obj.GetType() == GetType() && Equals((Material)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Name != null ? Name.GetHashCode() : 0;
                hashCode = (hashCode * 397) ^ ImportUnitPrice.GetHashCode();
                hashCode = (hashCode * 397) ^ ExportUnitPrice.GetHashCode();
                return hashCode;
            }
        }

        #endregion
    }
}
