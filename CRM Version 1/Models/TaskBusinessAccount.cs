using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;

namespace CRM_Version_1.Models
{
    public class TaskBusinessAccount
    {
        public string TaskBusinessAccountID { get; set; }

        public string TaskID { get; set; }
        public virtual Task task { get; set; }

        public string BusinessAccountID { get; set; }
        public virtual BusinessAccount businessaccount { get; set; }
    }
}