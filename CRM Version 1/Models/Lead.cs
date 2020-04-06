using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;

namespace CRM_Version_1.Models
{
    public class Lead
    {
        [Key]
        string LeadID { get; set; }
        public string UserID { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Company")]
        public string Company { get; set; }
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Event")]
        public string Event { get; set; }
        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Number { get; set; }
        [Required]
        [Display(Name = "Lead Source")]
        public string LeadSource { get; set; }
        [Required]
        [Display(Name = "Lead Status")]
        public string LeadStatus { get; set; }
        [Required]
        [Display(Name = "Industry")]
        public string Industry { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }
        DateTime DOB { get; set; }
    }
}