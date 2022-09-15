using System;
using System.Collections.Generic;

namespace WpfPersonalTracking.Db
{
    public partial class Month
    {
        public Month()
        {
            Salaries = new HashSet<Salary>();
        }

        public int MonthId { get; set; }
        public string? MonthName { get; set; }

        public virtual ICollection<Salary> Salaries { get; set; }
    }
}
