using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechAcadStudentsMVC.Models;

namespace TechAcadStudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page - The Tech Academy";

            return View();
        }

        public ActionResult Instructor(int id)
        {
            ViewBag.ID = id;

            Instructor dayTimeInstructor = new Instructor
            {
                ID = 1,
                FirstName = "Erik",
                LastName = "Gross"
            };

            return View(dayTimeInstructor);
        }

        public ActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    ID = 1,
                    FirstName = "Ricky",
                    LastName = "Ramen"
                },
                new Instructor
                {
                    ID = 2,
                    FirstName = "Brett",
                    LastName = "Calendar"
                },
                new Instructor
                {
                    ID = 3,
                    FirstName = "Adam",
                    LastName = "Lemons"
                }
            };
            return View(instructors);
        }
    }
}