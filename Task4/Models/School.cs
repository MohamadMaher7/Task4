using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Models
{
    internal class School
    {
        public List<Student> Students = new List<Student>();
        public List<Course> Courses = new List<Course>();
        public List<Instructor> Instructors = new List<Instructor>();

        public bool AddStudent(Student student)
        {
            Students.Add(student);
            return true;
        }

        public bool AddInstructor(Instructor instructor)
        {
            Instructors.Add(instructor);
            return true;
        }

        public bool AddCourse(Course course)
        {
            Courses.Add(course);
            return true;
        }

        public Student? FindStudent(int id)
        {
            return Students.FirstOrDefault(s => s.StudentId == id);
        }

        public Course? FindCourse(int id)
        {
            return Courses.FirstOrDefault(c => c.CourseId == id);
        }

        public Instructor? FindInstructor(int id)
        {
            return Instructors.FirstOrDefault(i => i.InstructorId == id);
        }

        public bool EnrollStudentInCourse(int studentId, int courseId)
        {
            Student? student = FindStudent(studentId);
            Course? course = FindCourse(courseId);

            if (student == null || course == null)
                return false;

            return student.Enroll(course);
        }
    }
}
