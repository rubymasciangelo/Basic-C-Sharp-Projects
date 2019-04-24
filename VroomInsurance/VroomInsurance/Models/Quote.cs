using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VroomInsurance.Models
{
    public class Quote
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

        public decimal DriverQuote(decimal quote)
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
             return driverQuote;

            if (Year < 2000 || Year > 2015)
            {
                driverQuote = driverQuote + 25;
            }
            return driverQuote;

            if (Make == "Porsche")
            {
                driverQuote = driverQuote + 25;
            }
            return driverQuote;

            if (Make == "Porsche" && Model == "911 Carrera")
            {
                driverQuote = driverQuote + 25;
            }
            return driverQuote;

            if (Tickets > 0)
            {
                driverQuote = driverQuote + (10 * Tickets);
            }
            return driverQuote;

            if (DUI == "Yes")
            {
                driverQuote = driverQuote + (driverQuote / 4);
            }
            return driverQuote;

            if (InsuranceType == "Full Coverage")
            {
                driverQuote = driverQuote + (driverQuote / 2);
            }
            return driverQuote = ApplicantQuote;
        }

        public decimal ApplicantQuote { get; set; }
    }
}
