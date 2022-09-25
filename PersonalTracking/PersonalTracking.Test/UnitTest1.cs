using Desktop.Contracts;
using Desktop.Model;
using Desktop.Views;
using Moq;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace PersonalTracking.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void LoadStudents()
        { 
            // Arrange 
            ObservableCollection<Student> students = new ObservableCollection<Student>();
            students.Add(new Student { FirstName = "Mark", LastName = "Allain" });
            students.Add(new Student { FirstName = "Allen", LastName = "Brown" });

            var Service = new Mock<IStudentViewModel>();
            //Service.Setup(x => x.LoadStudents(It.IsAny<string>())
            //    .Returns<string>(str => **whatever result you need * *);
            Service.Setup(x => x.StudentsExist()).Returns(true);
            Service.Setup(x => x.StudentsExist()).Returns(students);
            Service.Setup(x => x.LoadStudents()).Returns(students);
            //Service.

            //Assert.AreEqual(true, Service.)




            // Load the UserControl 
            var userControl = new StudentView();
            var measureSize = new Size(800, 500);
            userControl.Measure(measureSize);
            userControl.Arrange(new Rect(measureSize));
            userControl.UpdateLayout();
            userControl.DataContext = 
            Mock.Arrange(() => userControl.GetData()).ReturnsCollection(students);

            userControl.GridView.ItemsSource = userControl.GetData();

            // Act 
            string productName = "Apple";
            userControl.SelectOrdersByProduct(productName);
            Assert.IsTrue(userControl.GridView.SelectedItems.Count == 2);

        }
    }
}