﻿using System.Collections.Generic;

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
        public double VatPercent { get; }
        public string Reason { get; }

        public ExportReceipt(
            User employee,
            Customer customer,
            Warehouse warehouse,
            List<Material> materials,
            double totalPrice,
            double vat,
            double vatPercent,
            string reason)
            : this(-1, employee, customer, warehouse, materials, totalPrice, vat, vatPercent, reason)
        { }

        public ExportReceipt(
            int id,
            User employee,
            Customer customer,
            Warehouse warehouse,
            List<Material> materials,
            double totalPrice,
            double vat,
            double vatPercent,
            string reason)
        {
            Id = id;
            Employee = employee;
            Customer = customer;
            Warehouse = warehouse;
            Materials = materials;
            TotalPrice = totalPrice;
            Vat = vat;
            VatPercent = vatPercent;
            Reason = reason;
        }
    }
}
