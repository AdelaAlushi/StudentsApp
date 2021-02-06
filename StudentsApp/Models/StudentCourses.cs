using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentsApp.Models
{
    [Table("StudentCourses", Schema = "dbo")]
    public class StudentCourses
    {
        [Key, Column(Order = 0)]
        public int StudentId { get; set; }

        [Key, Column(Order = 1)]
        public int CourseId { get; set; }


        public virtual Student Student { get; set; }

        public virtual Courses Courses { get; set; }


        public string Grade { get; set; }


    }

}