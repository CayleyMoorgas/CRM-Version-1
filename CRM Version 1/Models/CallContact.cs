using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;

namespace CRM_Version_1.Models
{
    public class CallContact
    {
        public string CallContacID { get; set; }

        public string CallID { get; set; }
        public virtual Calls calls { get; set; }

        public string ContactID { get; set; }
        public virtual Contacts contacts { get; set; }

    }
}