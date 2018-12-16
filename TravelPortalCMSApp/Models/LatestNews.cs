using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelPortalCMSApp.Models
{
    public class LatestNews
    {
        [Key]
        public Int64 NewsID { get; set; }

        [Required(ErrorMessage = "News Title is required.")]
        [Display(Name = "Title")]
        [StringLength(50, MinimumLength = 1)]
        public string Title { get; set; }

        [Required(ErrorMessage = "News Body is required.")]
        [Display(Name = "Description")]
        [StringLength(500, MinimumLength = 1)]
        public string TitleBody { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        [Display(Name = "Date")]        
        public DateTime date { get; set; }
    }
}