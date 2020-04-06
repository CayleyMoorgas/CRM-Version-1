using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRM_Version_1.Models
{
    public class DocumentLead
    {
        public string DocumentLeadID { get; set; }

        public string DocumentID { get; set; }
        public virtual Document document { get; set; }

        public string LeadID { get; set; }
        public virtual Lead lead { get; set; }
    }
}