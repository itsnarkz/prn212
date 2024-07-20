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
    /// Interaction logic for TeacherView.xaml
    /// </summary>
    public partial class TeacherView : Window
    {
        private StudentService studentService;
        public TeacherView()
        {
            studentService = new StudentService();
            InitializeComponent();
        }

        private void load()
        {
            rollNumber.Text = "";
            name.Text = "";
            dob.Text = "";
            major.Text = "";
            classtxt.Text = "";
            phone.Text = "";
            email.Text = "";
            gpa.Text = "";

            dg.ItemsSource = studentService.GetStudents();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            load();
        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student student = dg.SelectedItem as Student;

            if (student == null) return;

            rollNumber.Text = student.RollNum;
            name.Text = student.Name;
            dob.Text = student.Dob;
            major.Text = student.Major;
            classtxt.Text = student.Class;
            phone.Text = student.Phone;
            email.Text = student.Email;
            gpa.Text = Math.Round((float) student.Gpa, 2).ToString();
        }

        private void add_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AddStudentView main = new AddStudentView();
            main.Show();
        }

        private void remove_btn_Click(object sender, RoutedEventArgs e)
        {
            Student student = this.dg.SelectedItem as Student;
            if (student == null) return;

            studentService.RemoveStudent(student);
            load();
        }

        private void logout_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            LoginWindow main = new LoginWindow();
            main.Show();
        }

        private void edit_btn_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student();

            student.RollNum = rollNumber.Text;
            student.Name = name.Text;
            student.Dob = dob.Text;
            student.Major = major.Text;
            student.Class = classtxt.Text;
            student.Phone = phone.Text;
            student.Email = email.Text;

            if (float.TryParse(gpa.Text, out float parsedGpa))
            {
                student.Gpa = Math.Round(parsedGpa, 2);
            }
            else
            {
                MessageBox.Show("Invalid GPA");
                return;
            }

            studentService.UpdateStudent(student);
            load();
        }

        private void noti_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            NotificationView main = new NotificationView(); 
            main.Show();
        }
    }
}
