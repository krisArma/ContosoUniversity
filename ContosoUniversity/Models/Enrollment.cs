using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        //This class will held the relation about Student entity with the Course Entity
        public int EnrollmentID { get; set; }   //This is the primary key of Enrollment entity
        public int CourseID { get; set; }   //This will held the Course ID taken from the Course entity (foreign key)
        public int StudentID { get; set; }  //This will held the Student ID taken from the Student entity (foreign Key)
        public Grade? Grade { get; set; }   //The question mark after the enum Grade indicates that this property is nullable

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}