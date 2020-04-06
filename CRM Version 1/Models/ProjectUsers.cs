using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;

namespace CRM_Version_1.Models
{
    public class ProjectUsers
    {
        public string ProjectUsersID { get; set; }
        
        public string ProjectID { get; set; }
        public virtual Project project { get; set; }

        public string UserID { get; set; }
        public virtual ApplicationUser applicationuser { get; set; }

        public string RolesID { get; set; }
        public virtual Roles roles { get; set; }
    }
}