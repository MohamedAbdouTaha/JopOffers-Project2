﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace Job_Offers_Website.Models
{
    public class ApplyForJob
    {
        public int Id { get; set; }
        [Display(Name ="الرساله")]
        public string Message { get; set; }
        [Display(Name = "تاريخ التقدم")]
        public DateTime ApplyDate { get; set; }
        public int JobId { get; set; }
        public string UserId { get; set; }

        public virtual Job job { get; set; }
        public virtual ApplicationUser user { get; set; }

    }
}