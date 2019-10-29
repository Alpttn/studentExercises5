using System;
using System.Collections.Generic;
using System.Text;

namespace StudentExercises5.Models
{

    public class Exercise
    {
        public string Name { get; set; }
        public string Language { get; set; }

        public Exercise(string name, string language)
        {
            Name = name;
            Language = language;
        }

    }

}
