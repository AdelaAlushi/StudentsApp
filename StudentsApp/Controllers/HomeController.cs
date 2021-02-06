using StudentsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var context = new AppDbContext();

            var students = context.Students.ToList();
            var courses = context.Courses.ToList();
            var studentCourse = context.StudentCourses.FirstOrDefault();

            var studentname = studentCourse.Student.Name;

            ViewData["MyData"] = students;

            return View(students.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}