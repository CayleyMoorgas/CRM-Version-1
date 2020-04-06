using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;

namespace CRM_Version_1.Models
{
    public class DocumentContact
    {
        public string DocumentContactID { get; set; }

        public string DocumentID { get; set; }
        public virtual Documents documents { get; set; }

        public string ContactID { get; set; }
        public virtual Contacts contacts { get; set; }

    }
}