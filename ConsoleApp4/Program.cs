using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
    
    public class Student
    {
        public int StudentID { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }

        public Student(int id, string name, int age, string grade)
        {
            StudentID = id;
            Name = name;
            Age = age;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"ID: {StudentID}, Name: {Name}, Age: {Age}, Grade: {Grade}";
        }
    }

    // تعريف فئة إدارة الطلاب
    public class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine("Student added successfully.");
        }

        public void RemoveStudent(int id)
        {
            Student student = students.Find(s => s.StudentID == id);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student removed successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void DisplayStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }

        public void FindStudent(int id)
        {
            Student student = students.Find(s => s.StudentID == id);
            if (student != null)
            {
                Console.WriteLine(student);
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();

            manager.AddStudent(new Student(1, "Ahmed", 20, "A"));
            manager.AddStudent(new Student(2, "Sara", 22, "B"));

            
            Console.WriteLine("All Students:");
            manager.DisplayStudents();

            Console.WriteLine("\nSearching for student with ID 1:");
            manager.FindStudent(1);

            
            Console.WriteLine("\nRemoving student with ID 2:");
            manager.RemoveStudent(2);

           
            Console.WriteLine("\nAll Students after removal:");
            manager.DisplayStudents();
        }
    }
}
