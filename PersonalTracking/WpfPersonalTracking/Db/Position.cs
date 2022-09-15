using System;
using System.Collections.Generic;

namespace WpfPersonalTracking.Db
{
    public partial class Position
    {
        public Position()
        {
            Employees = new HashSet<Employee>();
        }

        public int PositionId { get; set; }
        public string PositionName { get; set; } = null!;
        public int? DepartmentId { get; set; }

        public virtual Deparment? Department { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
