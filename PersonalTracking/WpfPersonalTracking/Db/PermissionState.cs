using System;
using System.Collections.Generic;

namespace WpfPersonalTracking.Db
{
    public partial class PermissionState
    {
        public PermissionState()
        {
            Permissions = new HashSet<Permission>();
        }

        public int PermissionStateId { get; set; }
        public string StateName { get; set; } = null!;

        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
