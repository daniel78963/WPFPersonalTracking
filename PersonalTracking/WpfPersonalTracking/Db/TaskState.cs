using System;
using System.Collections.Generic;

namespace WpfPersonalTracking.Db
{
    public partial class TaskState
    {
        public TaskState()
        {
            Tasks = new HashSet<Task>();
        }

        public int TaskStateId { get; set; }
        public string StateName { get; set; } = null!;

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
