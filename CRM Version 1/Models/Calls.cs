using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Data;


namespace CRM_Version_1.Models
{
    public class Calls
    {
        [Key]
        public string CallID { get; set; }
        public string UserID { get; set; }
        public virtual ApplicationUser applicationuser { get; set; }
        public string subject { get; set; }
        public string Purpose { get; set; }
        public string CallStatus { get; set; }
        public string AdditionalInformation { get; set; }
    }
}