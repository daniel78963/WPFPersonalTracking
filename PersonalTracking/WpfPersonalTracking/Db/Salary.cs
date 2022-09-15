using System;
using System.Collections.Generic;

namespace WpfPersonalTracking.Db
{
    public partial class Salary
    {
        public int SalaryId { get; set; }
        public int EmployeeId { get; set; }
        public int Amount { get; set; }
        public int Year { get; set; }
        public int MonthId { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual Month Month { get; set; } = null!;
    }
}
