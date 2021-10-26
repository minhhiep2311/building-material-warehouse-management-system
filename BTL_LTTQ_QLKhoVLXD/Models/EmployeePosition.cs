using System;
using System.Data;

namespace BTL_LTTQ_QLKhoVLXD.Models
{
    public class EmployeePosition : IEquatable<EmployeePosition>
    {
        public int Id { get; }
        public string Name { get; }

        public EmployeePosition(object id, object name)
        {
            Id = Convert.ToInt32(id);
            Name = Convert.ToString(name);
        }

        public static EmployeePosition FromData(DataRow data)
        {
            return new EmployeePosition(
                Convert.ToInt32(data["id"]),
                Convert.ToString(data["name"])
            );
        }

        public override string ToString()
        {
            return Name;
        }

        public bool Equals(EmployeePosition other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;

            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (obj is null) 
                return false;
            if (ReferenceEquals(this, obj)) 
                return true;

            return obj.GetType() == GetType() && Equals((EmployeePosition)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Id * 397) ^ (Name != null ? Name.GetHashCode() : 0);
            }
        }
    }
}
