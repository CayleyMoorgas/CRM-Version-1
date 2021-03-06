﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;

namespace CRM_Version_1.Models
{
    public class TaskCampaign
    {
        public string TaskCampaignID { get; set; }

        public string TaskID { get; set; }
        public virtual Task task { get; set; }

        public string CampaignID { get; set; }
        public virtual Campaign campaign { get; set; }
    }
}