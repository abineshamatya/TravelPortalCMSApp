using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelPortalCMSApp.Models
{
    public class PackagesModel
    {
        [Key]
        public Int64 PackageID { get; set; }

        [Required(ErrorMessage = "Package Name is required.")]
        [Display(Name = "Name")]
        [StringLength(50, MinimumLength = 1)]
        public string PackageName { get; set; }

        [Required(ErrorMessage = "Cost must be between $1 and $100000.")]
        [Range(1, 100000)]
        [Display(Name = "Cost")]
        public Double Cost { get; set; }

        [Required(ErrorMessage = "Package Type is required.")]
        [Display(Name = "Type")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Enter the Destination of Package.")]
        [Display(Name = "Destination")]
        public string Destination { get; set; }

        [Required(ErrorMessage = "Days must be between 1 & 365.")]
        [Range(1, 365)]
        [Display(Name = "Days")]
        public Double Days { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        public Int64 ImageID { get; set; }
        [ForeignKey("ImageID")]
        public virtual Image Image { get; set; }

        //public IEnumerable<PackagesModel> packageModel { get; set; }

    }
}