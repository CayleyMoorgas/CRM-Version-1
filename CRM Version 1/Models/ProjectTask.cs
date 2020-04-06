using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;

namespace CRM_Version_1.Models
{
    public class ProjectTask
    {
        public string ProjectTaskID { get; set; }

        public string TaskID { get; set; }
        public virtual Task task { get; set; }

        public string ProjectID { get; set; }
        public virtual Project project { get; set; }
    }
}