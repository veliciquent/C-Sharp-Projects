using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using CarInsurance.Models;


namespace CarInsurance.ViewModels
{
    public class InsureeVm
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