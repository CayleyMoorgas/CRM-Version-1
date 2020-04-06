
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;

namespace CRM_Version_1.Models
{
    public class CallBusinessAccount
    {
        public string CallBusinessAccountID { get; set; }

        public string CallID { get; set; }
        public virtual Call call { get; set; }

        public string BusinessAccountID { get; set; }
        public virtual BusinessAccount businessaccount { get; set; }
    }
}