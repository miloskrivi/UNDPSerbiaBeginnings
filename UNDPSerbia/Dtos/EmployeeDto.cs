using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using UNDPSerbia.Models;

namespace UNDPSerbia.Dtos
{
    public class EmployeeDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(6)]
        public string IndexNo { get; set; }

        [StringLength(15)]
        public string ContingencyId { get; set; }

        public bool? KeepAttendRec { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Supervisor { get; set; }

        public int? ExtensionNo { get; set; }

        [StringLength(30)]
        public string DirectBusinessPhone { get; set; }

        [StringLength(30)]
        public string BusinessMobile { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(30)]
        public string PrivateMobile { get; set; }

        [StringLength(150)]
        public string HomeAddress { get; set; }

        [StringLength(30)]
        public string HomePhone { get; set; }

        public DateTime? LastUpdate { get; set; }

        [StringLength(50)]
        public string LastUpdatedBy { get; set; }

        [StringLength(255)]
        public string Dependants { get; set; }

        [StringLength(7)]
        public string WardenTypeID { get; set; }

        public byte? WardenZoneID { get; set; }

        public DateTime? LastMedical { get; set; }

        public DateTime? NextMedical { get; set; }

        public DateTime? LastPersonalUpdate { get; set; }

        [StringLength(10)]
        public string LPNumber { get; set; }

        public DateTime? LPValidity { get; set; }

        public DateTime? EbankExpiryDate { get; set; }

        [StringLength(20)]
        public string Nationality { get; set; }

        [StringLength(20)]
        public string PassportNo { get; set; }

        public DateTime? PassportExpDate { get; set; }

        [StringLength(10)]
        public string BloodType { get; set; }

        [StringLength(10)]
        public string GMCID { get; set; }

        [StringLength(10)]
        public string VanBredaID { get; set; }

        [StringLength(12)]
        public string WardenClusterID { get; set; }

        [StringLength(30)]
        public string SkypeID { get; set; }

        public byte? WardenOrderNum { get; set; }

        [StringLength(255)]
        public string JMBG { get; set; }

        public bool? MoFAID { get; set; }
    }
}