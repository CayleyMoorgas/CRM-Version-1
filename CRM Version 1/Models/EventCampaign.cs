using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;

namespace CRM_Version_1.Models
{
    public class EventCampaign
    {
        public string EventCampaignID { get; set; }

        public string CampaignID { get; set; }
        public virtual Campaign campaign { get; set; }

        public string EventID { get; set; }
        public virtual Event events { get; set; }

    }
}