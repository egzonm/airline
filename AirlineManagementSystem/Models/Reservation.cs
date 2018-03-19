//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirlineManagementSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class Reservation
    {
        public int ReservationId { get; set; }
        [Required(ErrorMessage ="This field is required.")]
        public string From { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string Destination { get; set; } 
        [Display(Name = "Date From")]
        public Nullable<System.DateTime> DateFrom { get; set; }
        [Display(Name = "Date To")]
        public Nullable<System.DateTime> DateTo { get; set; }
        [Display(Name = "Flight Type")]
        public Nullable<int> FlighType { get; set; }
        [Display(Name = "No. of Children")]
        public Nullable<int> NoChildren { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<System.DateTime> LastModifiedOnDate { get; set; }
        public string CreatedByUserId { get; set; }
        public string LastModifiedByUserId { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
