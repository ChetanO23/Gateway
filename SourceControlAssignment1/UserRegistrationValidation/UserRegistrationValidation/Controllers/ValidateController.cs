using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserRegistrationValidation.Models;

namespace UserRegistrationValidation.Controllers
{
    public class ValidateController : Controller
    {
        // GET: Validate
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ValidateClass vc)
        {
            if (ModelState.IsValid)
            {
                ViewBag.firstname = vc.FirstName;
                ViewBag.lastname = vc.LastName;
                ViewBag.age = vc.Age;
                ViewBag.idnumber = vc.IDNumber;
                ViewBag.emailid = vc.EmailId;
                ViewBag.mobilenumber = vc.MobileNumber;
                ViewBag.pannumber = vc.PanNumber;
               // ViewBag.resumefile = vc.ResumeFile;
                ViewBag.gender = vc.Gender;
                return View("Index");
            }
            else
            {
                ViewBag.firstname = "No Data";
                ViewBag.lastname = "No Data";
                ViewBag.age = "No Data";
                ViewBag.idnumber = "No Data";
                ViewBag.emailid = "No Data";
                ViewBag.mobilenumber = "No Data";
                ViewBag.pannumber = "No Data";
                //ViewBag.resumefile = "No Data";
                ViewBag.gender = "No Data";
                return View("Index");
            }
            
        }
       /* [HttpPost]
        public ActionResult Index(HttpPostedFileBase ResumeFile)
        {
            string path = Server.MapPath("~/Uploads/");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (ResumeFile != null)
            {
                string fileName = Path.GetFileName(ResumeFile.FileName);
                ResumeFile.SaveAs(path + fileName);
                ViewBag.Message += string.Format("<b>{0}</b> uploaded.<br />", fileName);
            }

            return View();
        }
        */
    }
}