using System;
using System.Data;
using System.Windows.Forms;

namespace BTL_LTTQ_QLKhoVLXD.Models
{
    public class MaterialWarehouse
    {
        public Warehouse Warehouse { get; }
        public int Amount { get; }

        public MaterialWarehouse(Warehouse warehouse, int amount)
        {
            Warehouse = warehouse;
            Amount = amount;
        }

        public static MaterialWarehouse FromData(DataRow data)
        {
            var warehouse = Warehouse.FromData(data);
            var amount = Convert.ToInt32(data["amount"]);
            return new MaterialWarehouse(warehouse, amount);
        }

        public ListViewItem ToListViewItem()
        {
            var row = new ListViewItem(Warehouse.Id.ToString());
            row.SubItems.Add(Warehouse.Name);
            row.SubItems.Add(Amount.ToString());
            return row;
        }
    }
}
