using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;

namespace CRM_Version_1.Models
{
    public class DocumentCategory
    {
        
        public string DocumentCategoryID { get; set; }

        public string Category { get; set;  }

        public string CategoryID { get; set; }
        public virtual Document document { get; set; }


    }
}