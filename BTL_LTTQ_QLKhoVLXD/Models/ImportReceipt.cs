using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Services;
using BTL_LTTQ_QLKhoVLXD.Utils;

namespace BTL_LTTQ_QLKhoVLXD.Models
{
    public class ImportReceipt : Receipt
    {
        public Supplier Supplier { get; }

        public ImportReceipt(
            User employee,
            Supplier supplier,
            Warehouse warehouse,
            double totalPrice,
            DateTime dateTime,
            List<Material> materials = null)
            : this(-1, employee, supplier, warehouse, totalPrice, dateTime, materials)
        { }

        public ImportReceipt(
            int id,
            User employee,
            Supplier supplier,
            Warehouse warehouse,
            double totalPrice,
            DateTime dateTime,
            List<Material> materials = null)
        {
            Id = id;
            Employee = employee;
            Supplier = supplier;
            Warehouse = warehouse;
            TotalPrice = totalPrice;
            DateTime = dateTime;
            Materials = materials;
        }

        public virtual ListViewItem ToListViewItem()
        {
            var row = new ListViewItem(Id.ToString());
            row.SubItems.Add(Supplier.Name);
            row.SubItems.Add(Helper.Converter.ToString(DateTime));
            row.SubItems.Add(Helper.Converter.ToString(TotalPrice));
            row.SubItems.Add(Warehouse.Name);
            row.SubItems.Add(Employee.Name);
            return row;
        }

        public static ImportReceipt FromData(DataRow data)
        {
            var id = Convert.ToInt32(data["id"]);
            var employee = new User(Convert.ToString(data["employeeName"]));
            var supplier = new Supplier(Convert.ToString(data["supplierName"]));
            var warehouse = new Warehouse(Convert.ToString(data["name"]));
            var date = Convert.ToDateTime(data["date"]);
            var totalPrice = Convert.ToDouble(data["totalPrice"]);

            return new ImportReceipt(id, employee, supplier, warehouse, totalPrice, date);
        }

        public List<Material> GetMaterials()
        {
            return ReceiptService.GetMaterialsFromImportReceipt(this);
        }
    }
}
