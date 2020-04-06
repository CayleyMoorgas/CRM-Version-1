using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;

namespace CRM_Version_1.Models
{
    public class Project
    {
        [Key]
        public string ProjectID { get; set; }
        public string UserID { get; set; }
        public virtual ApplicationUser applicationuser { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set;  }
        public DateTime ProjectStartDate { get; set; }
        public DateTime ProjectEndDate { get; set; }
        
    }
}