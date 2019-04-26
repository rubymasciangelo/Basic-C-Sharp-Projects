using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VroomCarInsurance.Models;

namespace VroomCarInsurance.Controllers
{
    public class ApplicantController : Controller
    {
        private CarInsuranceEntities db = new CarInsuranceEntities();

        // GET: Applicant
        public ActionResult Index()
        {
            return View(db.Applicants.ToList());
        }

        // GET: Applicant/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicant applicant = db.Applicants.Find(id);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            return View(applicant);
        }

        // GET: Applicant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Applicant/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                decimal driverQuote = 50;

                var age = DateTime.Now.Year - applicant.DateOfBirth.Year;

                if (age < 25 || age > 100)
                {
                    driverQuote = driverQuote + 25;
                }
                else if (age < 18)
                {
                    driverQuote = driverQuote + 100;
                }


                if (applicant.CarYear < 2000 || applicant.CarYear > 2015)
                {
                    driverQuote = driverQuote + 25;
                }


                if (applicant.CarMake == "Porsche")
                {
                    driverQuote = driverQuote + 25;
                }


                if (applicant.CarMake == "Porsche" && applicant.CarModel == "911 Carrera")
                {
                    driverQuote = driverQuote + 25;
                }


                if (applicant.SpeedingTickets > 0)
                {
                    driverQuote = driverQuote + (10 * applicant.SpeedingTickets);
                }


                if (applicant.DUI == true)
                {
                    driverQuote = driverQuote + (driverQuote / 4);
                }


                if (applicant.CoverageType == "Full Coverage")
                {
                    driverQuote = driverQuote + (driverQuote / 2);
                }
                applicant.Quote = driverQuote;

                db.Applicants.Add(applicant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(applicant);
        }

        // GET: Applicant/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicant applicant = db.Applicants.Find(id);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            return View(applicant);
        }

        // POST: Applicant/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(applicant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(applicant);
        }

        // GET: Applicant/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applicant applicant = db.Applicants.Find(id);
            if (applicant == null)
            {
                return HttpNotFound();
            }
            return View(applicant);
        }

        // POST: Applicant/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Applicant applicant = db.Applicants.Find(id);
            db.Applicants.Remove(applicant);
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
