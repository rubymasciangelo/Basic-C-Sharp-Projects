using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VroomInsurance.Models;

namespace VroomInsurance.Controllers
{
    public class QuoteController : Controller
    {
        private InsuranceEntities1 db = new InsuranceEntities1();

        public ActionResult Index()
        {
            return View(db.Applications.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Application application = db.Applications.Find(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            return View(application);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Quote,FirstName,LastName,EmailAddress,MM,DD,YYYY,Year,Make,Model,DUI,Tickets,InsuranceType")] Application application)
        {
            if (ModelState.IsValid)
            {
                decimal driverQuote = 50;

                DateTime DOB = new DateTime(application.YYYY, application.MM, application.DD);
                DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

                var age = Convert.ToInt16(now - DOB);

                if (age < 25 || age > 100)
                {
                    driverQuote = driverQuote + 25;
                }
                else if (age < 18)
                {
                    driverQuote = driverQuote + 100;
                }


                if (application.Year < 2000 || application.Year > 2015)
                {
                    driverQuote = driverQuote + 25;
                }


                if (application.Make == "Porsche")
                {
                    driverQuote = driverQuote + 25;
                }


                if (application.Make == "Porsche" && application.Model == "911 Carrera")
                {
                    driverQuote = driverQuote + 25;
                }


                if (application.Tickets > 0)
                {
                    driverQuote = driverQuote + (10 * application.Tickets);
                }


                if (application.DUI == "Yes")
                {
                    driverQuote = driverQuote + (driverQuote / 4);
                }


                if (application.InsuranceType == "Full Coverage")
                {
                    driverQuote = driverQuote + (driverQuote / 2);
                }
                application.Quote = driverQuote;
            }

                db.Applications.Add(application);
                db.SaveChanges();
            return RedirectToAction("Applied");    
        }

        public ActionResult Edit(int? id) //id not being ID might become an issue
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Application application = db.Applications.Find(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            return View(application);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Quote,FirstName,LastName,EmailAddress,MM,DD,YYYY,Year,Make,Model,DUI,Tickets,InsuranceType")] Application application)
        {
            if (ModelState.IsValid)
            {
                db.Entry(application).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(application);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Application application = db.Applications.Find(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            return View(application);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Application application = db.Applications.Find(id);
            db.Applications.Remove(application);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}