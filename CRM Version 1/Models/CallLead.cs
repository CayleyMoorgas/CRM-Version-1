using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;

namespace CRM_Version_1.Models
{
    public class CallLead
    {
        public string CallLeadID { get; set; }

        public string CallID { get; set; }
        public virtual Calls calls { get; set; }

        public string LeadID { get; set; }
        public virtual Lead lead { get; set; }
    }
}