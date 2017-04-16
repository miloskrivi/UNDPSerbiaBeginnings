using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UNDPSerbia.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="First Name*")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name*")]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? DateOfBirth { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Work Position (Title)*")]
        public string Title { get; set; }

        [StringLength(6)]
        [Display(Name = "Employee Id")]
        public string IndexNo { get; set; }

        [StringLength(15)]
        [Display(Name = "Contingency Worker Id")]
        public string ContingencyId { get; set; }

        public bool? KeepAttendRec { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Supervisor { get; set; }

        [Display(Name = "Phone Extension No")]
        public int? ExtensionNo { get; set; }

        [StringLength(30)]
        [Display(Name = "Direct Business Phone")]
        public string DirectBusinessPhone { get; set; }

        [StringLength(30)]
        [Display(Name = "Business Mobile Phone")]
        public string BusinessMobile { get; set; }

        [StringLength(50)]
        [Display(Name = "Personal Email")]
        public string Email { get; set; }

        [StringLength(30)]
        [Display(Name = "Private Mobile Phone")]
        public string PrivateMobile { get; set; }

        [StringLength(150)]
        [Display(Name = "Home Address")]
        public string HomeAddress { get; set; }

        [StringLength(30)]
        [Display(Name = "Home Phone")]
        public string HomePhone { get; set; }

        [Display(Name = "Last Update")]
        public DateTime? LastUpdate { get; set; }

        [StringLength(50)]
        [Display(Name = "Last Updated By")]
        public string LastUpdatedBy { get; set; }

        [StringLength(255)]
        public string Dependants { get; set; }

        [StringLength(7)]
        [Display(Name = "Warden Type")]
        public string WardenTypeID { get; set; }

        [Display(Name = "Warden Zone")]
        public byte? WardenZoneID { get; set; }

        [Display(Name = "Date of Last Medical Clearance")]
        public DateTime? LastMedical { get; set; }

        public DateTime? NextMedical { get; set; }

        [Display(Name = "Last Personal Update")]
        public DateTime? LastPersonalUpdate { get; set; }

        [StringLength(10)]
        [Display(Name = "LP Number")]
        public string LPNumber { get; set; }

        [Display(Name = "LP Valid Until")]
        public DateTime? LPValidity { get; set; }

        public DateTime? EbankExpiryDate { get; set; }

        [StringLength(20)]
        public string Nationality { get; set; }

        [StringLength(20)]
        [Display(Name = "National Passport No")]
        public string PassportNo { get; set; }

        [Display(Name = "Passport Valid Until")]
        public DateTime? PassportExpDate { get; set; }

        [StringLength(10)]
        [Display(Name = "Blood Type")]
        public string BloodType { get; set; }

        [StringLength(10)]
        [Display(Name = "GMC Service Id")]
        public string GMCID { get; set; }

        [StringLength(10)]
        [Display(Name = "Van Breda Id")]
        public string VanBredaID { get; set; }

        [StringLength(12)]
        public string WardenClusterID { get; set; }

        [StringLength(30)]
        public string SkypeID { get; set; }

        public byte? WardenOrderNum { get; set; }

        [StringLength(255)]
        public string JMBG { get; set; }

        [Display(Name = "MoFA Id Holder")]
        public bool? MoFAID { get; set; }
    }
}