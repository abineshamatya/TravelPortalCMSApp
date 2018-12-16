using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TravelPortalCMSApp.Models;

namespace TravelPortalCMSApp.Controllers
{
    public class AdminController : Controller
    {
        public ApplicationDbContext db = new ApplicationDbContext();

        [Authorize(Roles = "Admin")]
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Slider(Slider model)
        {
            return View(model);
        }
        public ActionResult banner(Banner model)
        {
            return View(model);
        }
        public ActionResult welcome(Welcome model)
        {
            return View(model);
        }

        public ActionResult Packages()
        {
            return View("Packages");
        }


        public ActionResult LatestNews()
        {
            return View("LatestNews");
        }


        //Home Page- News Part
        [HttpPost]
        public ActionResult InsertLatestNews(LatestNews News)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.LatestNews.Add(News);
                    db.SaveChanges();
                    TempData["Success"] = "Success! Operation Done.";
                    return RedirectToAction("LatestNews");
                }
                catch (Exception)
                {
                    TempData["Success"] = "Failed! Operation Incomplete.";
                    return RedirectToAction("Error");
                }
            }
            return View(News);
        }
        [HttpPost]
        public JsonResult welcome(Welcome model, HttpPostedFileBase upload)
        {
            try
            {
                if (upload != null)
                {

                    string ImageName = System.IO.Path.GetFileName(upload.FileName);
                    string physicalPath = Server.MapPath("~/images/" + ImageName);

                    // save image in folder
                    upload.SaveAs(physicalPath);

                    //save new record in database
                    Welcome wel = new Welcome();
                    wel.Title = model.Title.ToUpper();
                    wel.Content =model.Content;
                    wel.ImageUrl = ImageName;
                    db.welcomes.Add(wel);
                    db.SaveChanges();
                    return Json("Successfully added.....");

                }
            }
            catch (RetryLimitExceededException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return Json("Error occured while saving Package...");

        }

        [HttpPost]
        public JsonResult AddSlider(Slider model, HttpPostedFileBase upload)
        {
            try
            {
                if (upload != null)
                {
                    
                    string ImageName = System.IO.Path.GetFileName(upload.FileName);
                    string physicalPath = Server.MapPath("~/images/" + ImageName);

                    // save image in folder
                    upload.SaveAs(physicalPath);

                    //save new record in database
                    Slider newRecord = new Slider();
                    newRecord.Title = model.Title;
                    newRecord.Cost = Convert.ToDouble(Request.Form["Cost"]);
                    newRecord.ImageUrl = ImageName;
                    db.Sliders.Add(newRecord);
                    db.SaveChanges();
                    return Json("Slider has been successfully added.....");

                }
            }
            catch (RetryLimitExceededException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return Json("Error occured while saving Package...");

        }

        [HttpPost]
        public JsonResult banner(Banner model, HttpPostedFileBase upload)
        {
            try
            {
                if (upload != null)
                {

                    string ImageName = System.IO.Path.GetFileName(upload.FileName);
                    string physicalPath = Server.MapPath("~/images/" + ImageName);

                    // save image in folder
                    upload.SaveAs(physicalPath);

                    //save new record in database
                    Banner ban = new Banner();
                    ban.Title = model.Title;
                    ban.Cost = Convert.ToDouble(Request.Form["Cost"]);
                    ban.ImageUrl = ImageName;
                    db.banners.Add(ban);
                    db.SaveChanges();
                    return Json("Banners has been successfully added.....");

                }
            }
            catch (RetryLimitExceededException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return Json("Error occured while saving Package...");

        }
        [HttpPost]
        public JsonResult AddPackages(PackagesModel packageModel,HttpPostedFileBase upload)
        {          
            Image image = new Image();
                try
                {
                    //var errors = ModelState.Values.SelectMany(v => v.Errors);
                    if (ModelState.IsValid)
                    {
                            packageModel.PackageName = packageModel.PackageName;
                            packageModel.PackageName = packageModel.PackageName;
                            packageModel.Cost = packageModel.Cost;
                            packageModel.Type = packageModel.Type;
                            packageModel.Description = packageModel.Description;
                            packageModel.Destination = packageModel.Destination;
                            packageModel.Days = packageModel.Days;
                            packageModel.DateCreated = DateTime.Now;
                            if(upload != null && upload.ContentLength > 0)
                            {
                                image.ImageName = System.IO.Path.GetFileName(upload.FileName);
                                image.ImageType = ImageType.Image_ID;
                                image.ContentType = upload.ContentType;
                                using (var reader = new System.IO.BinaryReader(upload.InputStream))
                                {
                                    image.Content = reader.ReadBytes(upload.ContentLength);
                                }
                            }
                            db.Images.Add(image);
                            db.PackageModels.Add(packageModel);
                            db.SaveChanges();
                            return Json("Package has been successfully added.....");
                    }
                }
                catch (RetryLimitExceededException /* dex */)
                {
                    //Log the error (uncomment dex variable name and add a line here to write a log.
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
                }
                return Json("Error occured while saving Package...");
               
       }

        public ActionResult EditIndex()
        {
            List<PackagesModel> packageModel = new List<PackagesModel>();
            using (db = new ApplicationDbContext())
            {
                packageModel = db.PackageModels.Where(p => p.PackageID == p.ImageID). ToList();
            }
            return View("EditIndex",packageModel);
        }


        //// GET: Admin/EditPackages/5
        //[Route("Admin/EditPackages/{id?}")]
        //public ActionResult EditPackages(long? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    PackagesModel packagesModel = db.PackageModels.Find(id);
        //    if (packagesModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View("EditPackages", packagesModel);
        //}

        // GET: Admin/EditImages/5
        [Route("Admin/EditImages/{id?}")]
        public FileContentResult EditImages(long? id)
        {
         
            Image imageModel  = db.Images.Find(id);
            byte[] bytePic = imageModel.Content;
            if(imageModel.ContentType == "image/jpg")
            {
                  return File(bytePic, "image/jpg");
            }
            else if(imageModel.ContentType == "image/png")
            {
                 return File(bytePic, "image/png");
            }
            else if (imageModel.ContentType == "image/jpeg")
            {
                return File(bytePic, "image/png");
            }
            else
            {
                return File(bytePic, "image/gif");
            }
        }

        [Authorize(Roles ="Admin")]
        // GET: Admin/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //EditImages(id);
            PackagesModel packagesModel = db.PackageModels.Find(id);
            if (packagesModel == null)
            {
                return HttpNotFound();
            }
            return View("Details", packagesModel);
        }


        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        // To protect from over-posting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AdminID,AdminName")] AdminModel adminModel)
        {
            if (ModelState.IsValid)
            {
                db.AdminModels.Add(adminModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adminModel);
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminModel adminModel = db.AdminModels.Find(id);
            if (adminModel == null)
            {
                return HttpNotFound();
            }
            return View(adminModel);
        }

        // POST: Admin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AdminID,AdminName")] AdminModel adminModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adminModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adminModel);
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdminModel adminModel = db.AdminModels.Find(id);
            if (adminModel == null)
            {
                return HttpNotFound();
            }
            return View(adminModel);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            AdminModel adminModel = db.AdminModels.Find(id);
            db.AdminModels.Remove(adminModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
