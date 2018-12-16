using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelPortalCMSApp.Models
{
    public class Image
    {
        [Key]
        public Int64 ImageID { get; set; }

        [StringLength(255)]
        public string ImageName { get; set; }

        [StringLength(100)]
        public string ContentType { get; set; }

        public byte[] Content { get; set; }

        public ImageType ImageType { get; set; }

    }
}