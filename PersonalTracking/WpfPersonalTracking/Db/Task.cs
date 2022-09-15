using System;
using System.Collections.Generic;

namespace WpfPersonalTracking.Db
{
    public partial class Task
    {
        public int TaskId { get; set; }
        public int EmployeeId { get; set; }
        public string TaskTitle { get; set; } = null!;
        public string? TaskContent { get; set; }
        public DateTime? TaskStartDate { get; set; }
        public DateTime? TaskDeliveryDate { get; set; }
        public int TaskStateId { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual TaskState TaskState { get; set; } = null!;
    }
}
