using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;

namespace CRM_Version_1.Models
{
    public class ProjectDeals
    {
        public string ProjectDealsID { get; set; }

        public string ProjectID { get; set; }
        public virtual Project project {get;set; }

        public string DealID { get; set; }
        public virtual Deals deals { get; set; }
    }
}