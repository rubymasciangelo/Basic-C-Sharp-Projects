using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VroomInsurance.Controllers
{
    public class QuoteController : Controller
    {
        public int MM { get; set; }
        public int DD { get; set; }
        public int YYYY { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string DUI { get; set; }
        public int Tickets { get; set; }
        public string InsuranceType { get; set; }
        
        // GET: Quote
        public ActionResult Index()
        {
            decimal driverQuote = 50;

            DateTime DOB = new DateTime(YYYY, MM, DD);
            DateTime now = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);

            var age = Convert.ToInt16(now - DOB);

            if (age < 25 || age > 100)
            {
                driverQuote = driverQuote + 25;
            }
            else if (age < 18)
            {
                driverQuote = driverQuote + 100;
            }


            if (Year < 2000 || Year > 2015)
            {
                driverQuote = driverQuote + 25;
            }


            if (Make == "Porsche")
            {
                driverQuote = driverQuote + 25;
            }


            if (Make == "Porsche" && Model == "911 Carrera")
            {
                driverQuote = driverQuote + 25;
            }


            if (Tickets > 0)
            {
                driverQuote = driverQuote + (10 * Tickets);
            }


            if (DUI == "Yes")
            {
                driverQuote = driverQuote + (driverQuote / 4);
            }


            if (InsuranceType == "Full Coverage")
            {
                driverQuote = driverQuote + (driverQuote / 2);
            }
            ViewBag.Result = driverQuote;
            return View();
        }
    }
}