﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentsApp.Models
{

    [Table("Courses", Schema = "dbo")]
    public class Courses
    {
        [Key]
        public int CourseId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<StudentCourses> StudentCourses { get; set; }
    }
}