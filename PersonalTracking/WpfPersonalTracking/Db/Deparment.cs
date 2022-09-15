using System;
using System.Collections.Generic;

namespace WpfPersonalTracking.Db
{
    public partial class Deparment
    {
        public Deparment()
        {
            Employees = new HashSet<Employee>();
            Positions = new HashSet<Position>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
    }
}
