using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppoDoc.Models
{
    public class MobUser
    {
        public int au_user_id { get; set; }
        [Required]
        [Display( Name = "First Name")]        
        public string au_firstname { get; set; }

        [Display(Name = "Last Name")]
        public string au_lastname { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [Display(Name = "Mobile Number")]
        public decimal au_reg_phone { get; set; }
        [Display(Name = "Email")]
        public string au_email { get; set; }
        [Display(Name = "Chart Number")]
        public string au_chart_no { get; set; }
        public int au_status { get; set; }
        public string au_last_update { get; set; }
        public string au_android_id { get; set; }
        public int au_otp { get; set; }
    }
   
}