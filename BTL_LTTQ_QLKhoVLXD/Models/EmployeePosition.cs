using System;
using System.Data;

namespace BTL_LTTQ_QLKhoVLXD.Models
{
    public class EmployeePosition
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        private EmployeePosition() { }

        public EmployeePosition(object id, object name)
        {
            Id = Convert.ToInt32(id);
            Name = Convert.ToString(name);
        }

        public static EmployeePosition FromData(DataRow data)
        {
            return new EmployeePosition
            {
                Id = Convert.ToInt32(data["id"]),
                Name = Convert.ToString(data["name"])
            };
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
