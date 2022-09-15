using System;
using System.Collections.Generic;

namespace WpfPersonalTracking.Db
{
    public partial class Permission
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime PermissionStartDate { get; set; }
        public DateTime PermissionEndDate { get; set; }
        public int PermissionStateId { get; set; }
        public string? PermissionExplanation { get; set; }
        public int PermissionDay { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual PermissionState PermissionState { get; set; } = null!;
    }
}
