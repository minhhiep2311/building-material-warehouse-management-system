using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BTL_LTTQ_QLKhoVLXD.Utils;

namespace BTL_LTTQ_QLKhoVLXD.Models
{
    public class ExportReceipt : Receipt
    {
        public Customer Customer { get; }
        public double Vat { get; }
        public double VatPercent { get; }
        public string Reason { get; }

        public ExportReceipt(
            User employee,
            Customer customer,
            Warehouse warehouse,
            double totalPrice,
            DateTime dateTime,
            List<Material> materials,
            double vat,
            double vatPercent,
            string reason)
            : this(-1, employee, customer, warehouse, totalPrice, dateTime, materials, vat, vatPercent, reason)
        { }

        public ExportReceipt(
            int id,
            User employee,
            Customer customer,
            Warehouse warehouse,
            double totalPrice,
            DateTime dateTime,
            List<Material> materials = null,
            double vat = default,
            double vatPercent = default,
            string reason = null)
        {
            Id = id;
            Employee = employee;
            Customer = customer;
            Warehouse = warehouse;
            TotalPrice = totalPrice;
            DateTime = dateTime;
            Materials = materials;
            Vat = vat;
            VatPercent = vatPercent;
            Reason = reason;
        }

        public virtual ListViewItem ToListViewItem()
        {
            var row = new ListViewItem(Id.ToString());
            row.SubItems.Add(Customer.Name);
            row.SubItems.Add(Helper.Converter.ToString(DateTime));
            row.SubItems.Add(Helper.Converter.ToString(TotalPrice));
            row.SubItems.Add(Warehouse.Name);
            row.SubItems.Add(Employee.Name);
            return row;
        }
        public static ExportReceipt FromData(DataRow data)
        {
            var id = Convert.ToInt32(data["id"]);
            var employee = new User(Convert.ToString(data["customerName"]));
            var customer = new Customer(Convert.ToString(data["supplierName"]));
            var warehouse = new Warehouse(Convert.ToString(data["name"]));
            var date = Convert.ToDateTime(data["date"]);
            var totalPrice = Convert.ToDouble(data["totalPrice"]);

            return new ExportReceipt(id, employee, customer, warehouse, totalPrice, date);
        }

    }
}
