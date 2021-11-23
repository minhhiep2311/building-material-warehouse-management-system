using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_LTTQ_QLKhoVLXD.Models
{
    internal class ExportReceipt
    {
        public int Id { get; set; }
        public User Employee { get; }
        public Supplier Supplier { get; }
        public Warehouse Warehouse { get; }
        public List<Material> Materials { get; }
        public double TotalPrice { get; }
        public double Vat { get; }
        public string Reason { get; }

        public ExportReceipt(
            User employee,
            Supplier supplier,
            Warehouse warehouse,
            List<Material> materials,
            double totalPrice,
            double vat, 
            string reason)
            : this(-1, employee, supplier, warehouse, materials, totalPrice, vat, reason)
        { }

        public ExportReceipt(
            int id,
            User employee,
            Supplier supplier,
            Warehouse warehouse,
            List<Material> materials,
            double totalPrice, 
            double vat,
            string reason)
        {
            Id = id;
            Employee = employee;
            Supplier = supplier;
            Warehouse = warehouse;
            Materials = materials;
            TotalPrice = totalPrice;
            Vat = vat;
            Reason = reason;
        }
    }
}
