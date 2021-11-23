using System.Collections.Generic;

namespace BTL_LTTQ_QLKhoVLXD.Models
{
    class ImportReceipt
    {
        public int Id { get; set; }
        public User Employee { get; }
        public Supplier Supplier { get; }
        public Warehouse Warehouse { get; }
        public List<Material> Materials { get; }
        public double TotalPrice { get; }

        public ImportReceipt(
            User employee,
            Supplier supplier,
            Warehouse warehouse,
            List<Material> materials,
            double totalPrice)
            : this(-1, employee, supplier, warehouse, materials, totalPrice)
        { }

        public ImportReceipt(
            int id,
            User employee,
            Supplier supplier,
            Warehouse warehouse,
            List<Material> materials,
            double totalPrice)
        {
            Id = id;
            Employee = employee;
            Supplier = supplier;
            Warehouse = warehouse;
            Materials = materials;
            TotalPrice = totalPrice;
        }

    }
}
