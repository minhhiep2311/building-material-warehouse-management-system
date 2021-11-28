using System.Collections.Generic;

namespace BTL_LTTQ_QLKhoVLXD.Models
{
    public class Receipt
    {
        public int Id { get; set; }
        public User Employee { get; set; }
        public Warehouse Warehouse { get; set; }
        public List<Material> Materials { get; set; }
        public double TotalPrice { get; set; }
    }
}
