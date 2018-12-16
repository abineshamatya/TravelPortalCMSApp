using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelPortalCMSApp.Models
{
    public class Slider
    {
        [Key]
        public Int64 sliderID { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [Display(Name = "Title")]
        [StringLength(50, MinimumLength = 1)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Cost must be between $1 and $100000.")]
        [Range(1, 100000)]
        [Display(Name = "Cost")]
        public Double Cost { get; set; }

        public string ImageUrl { get; set; }
    }
    public class Banner
    {
        [Key]
        public Int64 bannerID { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [Display(Name = "Title")]
        [StringLength(50, MinimumLength = 1)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Cost must be between $1 and $100000.")]
        [Range(1, 100000)]
        [Display(Name = "Cost")]
        public Double Cost { get; set; }

        public string ImageUrl { get; set; }
    }
    public class Welcome
    {
        [Key]
        public Int64 ID { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [Display(Name = "Title")]
        [StringLength(50, MinimumLength = 1)]
        public string Title { get; set; }

        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Content is required")]
        [Display(Name = "Content")]
        public string Content { get; set; }
    }
}