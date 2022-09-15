using System;
using System.Collections.Generic;

namespace WpfPersonalTracking.Db
{
    public partial class Employee
    {
        public Employee()
        {
            Permissions = new HashSet<Permission>();
            Salaries = new HashSet<Salary>();
            Tasks = new HashSet<Task>();
        }

        public int EmployeeId { get; set; }
        public int UserNo { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string? ImagePath { get; set; }
        public int DepartmentId { get; set; }
        public int PositionId { get; set; }
        public int Salary { get; set; }
        public DateTime? BirthDay { get; set; }
        public string? Address { get; set; }
        public string? Password { get; set; }
        public bool? IsAdmin { get; set; }

        public virtual Deparment Department { get; set; } = null!;
        public virtual Position Position { get; set; } = null!;
        public virtual ICollection<Permission> Permissions { get; set; }
        public virtual ICollection<Salary> Salaries { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
