using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelPortalCMSApp.Models
{
    public class ImagePath
    {
        public int ImagePathId { get; set; }

        [StringLength(255)]
        public string ImageName { get; set; }

        public ImageType ImageType { get; set; }

    }
}