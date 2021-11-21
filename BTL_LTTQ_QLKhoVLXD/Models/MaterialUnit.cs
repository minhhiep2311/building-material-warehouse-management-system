using System;

namespace BTL_LTTQ_QLKhoVLXD.Models
{
    public class MaterialUnit
    {
        public int Id { get; }
        public string Name { get; }

        public MaterialUnit(object id, object name)
        {
            Id = Convert.ToInt32(id);
            Name = Convert.ToString(name);
        }
    }
}
