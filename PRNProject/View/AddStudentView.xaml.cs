using PRNProject.Models;
using PRNProject.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PRNProject.View
{
    /// <summary>
    /// Interaction logic for AddStudentView.xaml
    /// </summary>
    public partial class AddStudentView : Window
    {
        StudentService studentService;
        public AddStudentView()
        {
            studentService = new StudentService();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student();

            if (!string.IsNullOrWhiteSpace(rollNumber.Text) &&
                !string.IsNullOrWhiteSpace(name.Text) &&
                !string.IsNullOrWhiteSpace(email.Text) &&
                !string.IsNullOrWhiteSpace(dob.Text) &&
                !string.IsNullOrWhiteSpace(phone.Text) &&
                !string.IsNullOrWhiteSpace(major.Text) &&
                !string.IsNullOrWhiteSpace(classtxt.Text) &&
                !string.IsNullOrWhiteSpace(gpa.Text))
            {
                student.RollNum = rollNumber.Text;
                student.Name = name.Text;
                student.Email = email.Text;
                student.Dob = dob.Text;
                student.Phone = phone.Text;
                student.Major = major.Text;
                student.Class = classtxt.Text;
                try
                {
                    student.Gpa = Math.Round(float.Parse(gpa.Text), 2);
                    if (student.Gpa < 0 || student.Gpa > 10) throw new Exception();
                } catch(Exception ex)
                {
                    MessageBox.Show("Invalid gpa!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }


            studentService.AddStudent(student);
            this.Hide();
            TeacherView main = new TeacherView();
            main.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            TeacherView main = new TeacherView();
            main.Show();
        }
    }
}
