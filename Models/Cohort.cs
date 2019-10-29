using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercises5.Models
{
    public class Cohort
    {

        public string Name { get; set; }
        public List<Student> StudentList { get; set; } = new List<Student>();

        public List<Instructor> InstructorList { get; set; } = new List<Instructor>();

        public Cohort(string name)
        {
            Name = name;
        }

    }
}

