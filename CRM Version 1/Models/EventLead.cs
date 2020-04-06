using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRM_Version_1.Models
{
    public class EventLead
    {
        public string EventLeadID { get; set; }

        public string EventID { get; set; }
        public virtual Event event { get; set; }

        public string LeadID { get; set; }
        public virtual Lead lead { get; set; }

        public string participant { get; set; }
    }
}