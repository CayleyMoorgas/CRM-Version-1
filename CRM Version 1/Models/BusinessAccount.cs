using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;

namespace CRM_Version_1.Models
{
    public class BusinessAccount
    {
        [Key]
        public string BusinessAccountID { get; set; }
        public string UserID { get; set; }
        public virtual ApplicationUser applicationuser { get; set; }
        public string Name { get; set; }
        public string AccountSite { get; set; }
        public string AccountType { get; set; }
        public string Industry { get; set; }
        public string Employees { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public decimal AnnualRevenue { get; set; }
        


    }
}