using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Models
{
    internal class Course
    {
        public int CourseId { get; init; }
        public string Title { get; set; }
        public Instructor Instructor { get; init; }

        public Course(int id, string title, Instructor instructor)
        {
            CourseId = id;
            Title = title;
            Instructor = instructor;
        }

        public string PrintDetails()
        {
            return $"ID: {CourseId}, Title: {Title}, Instructor: {Instructor.Name}";
        }
    }
}
