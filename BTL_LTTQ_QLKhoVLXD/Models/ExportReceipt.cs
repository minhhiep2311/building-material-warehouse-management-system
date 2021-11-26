using System.Collections.Generic;

namespace BTL_LTTQ_QLKhoVLXD.Models
{
    public class ExportReceipt
    {
        public int Id { get; set; }
        public User Employee { get; }
        public Customer Customer { get; }
        public Warehouse Warehouse { get; }
        public List<Material> Materials { get; }
        public double TotalPrice { get; }
        public double Vat { get; }
        public string Reason { get; }

        public ExportReceipt(
            User employee,
            Customer customer,
            Warehouse warehouse,
            List<Material> materials,
            double totalPrice,
            double vat, 
            string reason)
            : this(-1, employee, customer, warehouse, materials, totalPrice, vat, reason)
        { }

        public ExportReceipt(
            int id,
            User employee,
            Customer customer,
            Warehouse warehouse,
            List<Material> materials,
            double totalPrice, 
            double vat,
            string reason)
        {
            Id = id;
            Employee = employee;
            Customer = customer;
            Warehouse = warehouse;
            Materials = materials;
            TotalPrice = totalPrice;
            Vat = vat;
            Reason = reason;
        }
    }
}
