using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRM_Version_1.Models
{
    public class DocumentCampaign
    {
        public string DocumentCampaignID { get; set; }

        public string DocumentID { get; set; }
        public virtual Document document { get; set; }

        public string CampaignID { get; set; }
        public virtual Campaign campaign {get;set;}


    }
}