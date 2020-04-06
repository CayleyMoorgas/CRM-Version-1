using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;

namespace CRM_Version_1.Models
{
    public class Contacts
    {
        [Key]
        public String ContactID { get; set; }

        public string LeadID { get; set; }
        public virtual Lead lead { get; set; }

        public string Department { get; set; }
        public virtual BusinessAccount businessaccount { get; set; }

    }
}