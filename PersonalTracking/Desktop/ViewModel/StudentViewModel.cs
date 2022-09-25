using Desktop.Contracts;
using Desktop.Model;
using System.Collections.ObjectModel;

namespace Desktop.ViewModel
{
    public class StudentViewModel : IStudentViewModel
    {
        public StudentViewModel()
        {
            LoadStudents();
        }

        public ObservableCollection<Student> Students { get; set; }

        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();
            students.Add(new Student { FirstName = "Mark", LastName = "Allain" });
            students.Add(new Student { FirstName = "Allen", LastName = "Brown" });
            students.Add(new Student { FirstName = "Linda", LastName = "Hamerski" });
            Students = students;
        }

        public bool StudentsExist()
        {
            return true;
        }
    }
}
