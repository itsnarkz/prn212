using PRNProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PRNProject.Service
{
    internal class StudentService
    {
        private Prn212Context db;

        public StudentService() { 
            db = new Prn212Context();
        }

        public List<Student> GetStudents()
        {
            return db.Students.ToList();
        }

        public void AddStudent(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
        }

        public void RemoveStudent(Student student)
        {
            db.Students.Remove(student);
            db.SaveChanges();
        }

        public void UpdateStudent(Student student) 
        {
                var studentToUpdate = db.Students.SingleOrDefault(s => s.RollNum == student.RollNum);

                if (studentToUpdate != null)
                {
                    // Update the student's properties
                    studentToUpdate.Name = student.Name;
                    studentToUpdate.Dob = student.Dob;
                    studentToUpdate.Major = student.Major;
                    studentToUpdate.Class = student.Class;
                    studentToUpdate.Phone = student.Phone;
                    studentToUpdate.Email = student.Email;
                    studentToUpdate.Gpa = student.Gpa;

                    // Save changes to the database
                    db.SaveChanges();

                    Console.WriteLine("Student updated successfully.");
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            


        }
    }
}
