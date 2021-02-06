namespace StudentsApp.Migrations
{
    using StudentsApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentsApp.Models.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StudentsApp.Models.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Students.AddOrUpdate(new Student()
            {
                StudentId = 1,
                Name = "Adela",
                Age = 22

            });
            context.Students.AddOrUpdate(new Student()
            {
                StudentId = 2,
                Name = "Student2",
                Age = 20


            });
            context.Courses.AddOrUpdate(new Courses()
            {
                CourseId = 1,
                Name = ".NET"



            });
            context.Courses.AddOrUpdate(new Courses()
            {
                CourseId = 2,
                Name = "Java"



            });
            context.StudentCourses.AddOrUpdate(new StudentCourses()

            {
                StudentId = 1,
                CourseId = 1,
                Grade = "Good"



            });
            context.StudentCourses.AddOrUpdate(new StudentCourses()

            {
                StudentId = 2,
                CourseId = 2,
                Grade = "Good"



            });
        }
    }
}
