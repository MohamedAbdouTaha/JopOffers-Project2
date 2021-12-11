using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Job_Offers_Website.Models
{
    public class ContactModel
    {
        [Required]
        [Display(Name ="الأسم")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "البريد الالكتروني")]
        public string Email { get; set; }
        [Required]
        [AllowHtml]
        [Display(Name = "الموضوع")]
        public string Subject { get; set; }
        [Required]
        [Display(Name = "الرساله")]
        public string Message { get; set; }
    }
}