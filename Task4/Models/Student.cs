using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Models
{
    internal class Student
    {
        public int StudentId { get; init; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Course> Courses { get; }

        public Student(int id, string name, int age)
        {
            StudentId = id;
            Name = name;
            Age = age;
            Courses = new List<Course>();
        }

        public bool Enroll(Course course)
        {
            if (Courses.Contains(course))
                return false;

            Courses.Add(course);
            return true;
        }

        public string PrintDetails()
        {
            string courseNames = Courses.Count == 0
                ? "No courses"
                : string.Join(", ", Courses.Select(c => c.Title));

            return $"ID: {StudentId}, Name: {Name}, Age: {Age}, Courses: {courseNames}";
        }
    }
}
