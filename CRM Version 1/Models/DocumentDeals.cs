using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;

namespace CRM_Version_1.Models
{
    public class DocumentDeals
    {
        public string DocumentDealsID { get; set; }

        public string DocumentID { get; set; }
        public virtual Document document { get; set; }

        public string DealID { get; set; }
        public virtual Deals deals { get; set; }
    }
}