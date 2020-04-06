using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;
namespace CRM_Version_1.Models
{
    public class Campaign
    {
        [Key]
        public string CampaignID { get; set; }
        public string UserID { get; set; }
        public virtual ApplicationUser applicationuser { get; set; }
        public DateTime StartDate { get; set; }
        public string CampaignName { get; set; }
        public decimal ExpectedRevene { get; set; }
        public decimal ActualCost { get; set; }
        public string CampaignType { get; set; }
        public string Status { get; set; }
        public DateTime EndDate { get; set; }
        public decimal BudgetedCost { get; set; }
        public string ExpectedResponse { get; set; }
        public string AdditionalInfo { get; set; }
    }
}