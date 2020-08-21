using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Appsierra_MailApp.Models
{
    public class EmailModel
    {
        [DataType(DataType.EmailAddress), Display(Name = "To")]
        [Required]
        public string ToEmail { get; set; }
        [Display(Name = "Subject")]
        public string EmailSubject { get; set; }
        [Display(Name = "Body")]
        [DataType(DataType.MultilineText)]
        public string EMailBody { get; set; }
       
    }
}