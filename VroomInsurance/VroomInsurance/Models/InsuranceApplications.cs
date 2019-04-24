using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VroomInsurance.Models
{
    public class InsuranceApplications
    {
        public int ID { get; set; }
        public decimal Quote { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}