//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarInsurance.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Insuree
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string EmailAddress { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public System.DateTime DateOfBirth { get; set; }
        public int CarYear { get; set; }
        [StringLength(50)]
        public string CarMake { get; set; }
        [StringLength(50)]
        public string CarModel { get; set; }
        public bool DUI { get; set; }
        public int SpeedingTickets { get; set; }
        public bool CoverageType { get; set; }
        public decimal Quote { get; set; }
    }
}