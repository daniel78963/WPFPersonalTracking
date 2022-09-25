using Desktop.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Contracts
{
    public interface IStudentViewModel
    { 

        public void LoadStudents();

        public bool StudentsExist();
    }
}
