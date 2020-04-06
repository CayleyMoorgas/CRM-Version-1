using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;

namespace CRM_Version_1.Models
{
    public class CallUser
    {
        public string CallUserID { get; set; }

        public string CallID { get; set;}
        public virtual Calls call { get; set; }

        public string UserID { get; set; }
        public virtual ApplicationUser applicationuser { get; set; }

    }
}