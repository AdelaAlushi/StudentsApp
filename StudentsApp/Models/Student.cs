using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentsApp.Models
{
    [Table("Student", Schema = "dbo")]
    public class Student

    {

        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }

        public virtual ICollection<StudentCourses> StudentCourses { get; set; }
    }
}