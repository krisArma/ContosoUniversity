using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Student
    {
        //This class hanlde the model of Students (Database)
        public int ID { get; set; }     //This is the primary key which has unique chriteria
        public string LastName { get; set; }    //Lastname of the students
        public string FirstMidName { get; set; }    //First and Mid name of the students
        public DateTime EnrollmentDate { get; set; }    //Held the information about another entities which related to this entity

        public virtual ICollection<Enrollment> Enrollments { get; set; }    //Same as the Date XD
    }
}