using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentsApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("StudentsDb")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<StudentCourses> StudentCourses { get; set; }
    }
}