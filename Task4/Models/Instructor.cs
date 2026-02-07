using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Models
{
    internal class Instructor
    {
        public int InstructorId { get; init; }
        public string Name { get; set; }
        public string Specialization { get; set; }

        public Instructor(int id, string name, string specialization)
        {
            InstructorId = id;
            Name = name;
            Specialization = specialization;
        }

        public string PrintDetails()
        {
            return $"ID: {InstructorId}, Name: {Name}, Specialization: {Specialization}";
        }
    }
}
