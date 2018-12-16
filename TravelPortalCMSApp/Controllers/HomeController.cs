using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelPortalCMSApp.Models;

namespace TravelPortalCMSApp.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";

            return View("About");
        }

        public ActionResult HotTours()
        {
            //ViewBag.Message = "Your application description page.";

            return View("HotTours");
        }

        public ActionResult SpecialOffers()
        {
            //ViewBag.Message = "Your application description page.";

            return View("SpecialOffers");
        }

        public ActionResult Blog()
        {
            //ViewBag.Message = "Your application description page.";

            return View("Blog");
        }

        public ActionResult Packages()
        {
            List<Object> packageModel = new List<Object>();
            using (db = new ApplicationDbContext())
            {
               
                packageModel.Add(db.PackageModels.ToList());
                packageModel.Add(db.Images.ToList());
            }
            //ViewBag.Image = GetImagesBytes(image);
            return View("Packages", packageModel);
        }

        //public Byte GetImagesBytes()
        //{
        //    Image imageModel = new Image();
        //    byte[] bytePic = imageModel.Content;
        //    if (imageModel.ContentType == "image/jpg")
        //    {
        //        return bytePic;
        //    }
        //    else if (imageModel.ContentType == "image/png")
        //    {
        //        return File(bytePic, "image/png");
        //    }
        //    else if (imageModel.ContentType == "image/jpeg")
        //    {
        //        return File(bytePic, "image/png");
        //    }
        //    else
        //    {
        //        return File(bytePic, "image/gif");
        //    }
        //}

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";

            return View("Contact");
        }
    }
}