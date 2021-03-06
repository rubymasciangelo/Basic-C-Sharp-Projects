//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VroomCarInsurance.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Reflection;

    public partial class Applicant
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; } //testing enumdropdown
        public string CarModel { get; set; } //testing editorfor
        public bool DUI { get; set; }
        public int SpeedingTickets { get; set; }
        public string CoverageType { get; set; }
        public decimal Quote { get; set; }



        //public enum Make
        //{
        //    Suzuki,
        //    Porsche,
        //    Subaru,
        //    Honda
        //}

        //public enum Model
        //{
        //    Cappuccino,
        //    [Display(Name = "911 Carrera")]
        //    Carrera,
        //    Macan,
        //    Cayenne,
        //    Outback,
        //    WRX,
        //    Crosstrek,
        //    Civic,
        //    Odyssey
        //}

        //public enum Coverage
        //{
        //    [Display(Name = "Full Coverage")]
        //    Full,
        //    Liability
        //}
    }
}
