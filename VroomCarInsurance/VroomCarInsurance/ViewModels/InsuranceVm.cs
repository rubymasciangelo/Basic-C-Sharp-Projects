using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VroomCarInsurance.ViewModels
{
    public class InsuranceVm
    {
        public decimal Quote { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }
}