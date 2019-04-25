using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VroomInsurance.Models;
using VroomInsurance.ViewModels;

namespace VroomInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Apply(string firstName, string lastName, string emailAddress, int MM, int DD, int YYYY, Int16 year,
        //                    string make, string model, string DUI, Int16 tickets, string insuranceType)
        //{
        //    using (InsuranceEntities db = new InsuranceEntities())
        //    {
        //        var application = new Application();
        //        application.FirstName = firstName;
        //        application.LastName = lastName;
        //        application.EmailAddress = emailAddress;
        //        application.DoB = new DateTime(YYYY, MM, DD);
        //        application.Year = year;
        //        application.Make = make;
        //        application.Model = model;
        //        application.DUI = DUI;
        //        application.Tickets = tickets;
        //        application.InsuranceType = insuranceType;

        //        db.Applications.Add(application);
        //        db.SaveChanges();
        //    }

        //    return View("Applied");
        //}

    }
}