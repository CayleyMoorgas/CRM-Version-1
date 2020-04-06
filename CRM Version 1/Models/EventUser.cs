
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;

namespace CRM_Version_1.Models
{
    public class EventUser
    {
        public string EventUserID { get; set; }

        public string EventID { get; set; }
        public virtual Event events { get; set; }

        public string UserID { get; set; }
        public virtual ApplicationUser applicationuser { get; set;  }

        public string Participant { get; set; }
    }
}