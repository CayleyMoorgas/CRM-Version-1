using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;

namespace CRM_Version_1.Models
{
    public class Deals
    {
        [Key]

        public string DealID { get; set; }
        public string UserID { get; set; }
        public virtual ApplicationUser applicationuser { get; set; }
        public string DealName { get; set; }
        public string ContactID { get; set; }
        public virtual Contacts contacts { get; set; }
        public string DealType { get; set; }
        public decimal DealAmount { get; set; }
        public DateTime ClosingDate { get; set; }
        public string Stage { get; set; }
        public string Probability { get; set; }
        public decimal ExpectedRevenue { get; set; }
        public string CampaignID { get; set; }
        public virtual Campaign campaign { get; set; }
        
    }
}