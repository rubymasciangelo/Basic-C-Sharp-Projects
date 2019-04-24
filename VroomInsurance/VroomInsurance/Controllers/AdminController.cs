using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VroomInsurance.Models;
using VroomInsurance.ViewModels;

namespace VroomInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var applications = db.Applications;
                var applicationVms = new List<ApplicationVM>();
                foreach (var application in applications)
                {
                    var applicationVm = new ApplicationVM();
                    applicationVm.Quote = application.Quote;
                    applicationVm.FirstName = application.FirstName;
                    applicationVm.LastName = application.LastName;
                    applicationVm.EmailAddress = application.EmailAddress;
                    applicationVms.Add(applicationVm);
                }

                return View(applicationVms);
            }
        }
    }
}