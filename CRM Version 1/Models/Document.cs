using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;

namespace CRM_Version_1.Models
{
    public class Document
    {
        [Key]
        public string DocumentID { get; set; }
        public string UserID { get; set; }
        public virtual ApplicationUser applicationuser { get; set; }
        public string CategoryID { get; set; }
        public string DocumentName { get; set; }
        public string DocumentDescription { get; set; }
        public int VersionNumber { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        
    }
}