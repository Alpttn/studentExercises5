﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercises5.Models
{

    public class Instructor : NSSPerson
    {
        public string InstructorSpeciality { get; set; }

        public Instructor(string firstName, string lastName, string slackHandle, Cohort cohort, string instructorSpeciality)
        {
            FirstName = firstName;
            LastName = lastName;
            SlackHandle = slackHandle;
            Cohort = cohort;
            InstructorSpeciality = instructorSpeciality;
        }

        public void assignExercise(Student student, Exercise exercise)
        {
            student.exerciseList.Add(exercise);
        }

    }
}

