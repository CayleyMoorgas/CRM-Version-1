using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;
namespace CRM_Version_1.Models
{
    public class CallsCampaign
    {
        public string CallsCampaignID { get; set; }

        public string CallID { get; set; }
        public virtual Calls calls { get; set; }

        public string CampaignID { get; set; }
        public virtual Campaign campaign { get; set; }


    }
}