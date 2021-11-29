using System;
using System.Data;

namespace BTL_LTTQ_QLKhoVLXD.Models
{
    public class MaterialUnit
    {
        public int Id { get; }
        public string Name { get; }

        public MaterialUnit(object name) : this(-1, name) { }

        public MaterialUnit(object id, object name)
        {
            Id = Convert.ToInt32(id);
            Name = Convert.ToString(name);
        }

        public static MaterialUnit FromData(DataRow data)
        {
            var id = Convert.ToInt32(data["id"]);
            var name = Convert.ToString(data["name"]);

            return new MaterialUnit(id, name);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
