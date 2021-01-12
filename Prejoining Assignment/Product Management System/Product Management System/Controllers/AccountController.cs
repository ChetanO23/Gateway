using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using log4net;
using NLog.Fluent;
using Product_Management_System.Models;

namespace Product_Management_System.Controllers
{
    public class AccountController : Controller
    {
        ProductManagementEntities db = new ProductManagementEntities();

       // internal static Ilog Log { get; } = LogManager.GetLogger(typeof(AccountController));

        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Models.Membership model)
        {
            try
            {
                var auth = db.Users.Where(a => a.Username.Equals(model.Username) && a.Password.Equals(model.Password)).FirstOrDefault();
                if (auth != null)
                {
                    FormsAuthentication.SetAuthCookie(model.Username, false);
                    Log.Info("Login SuccessFul");
                    Session["User_id"] = auth.User_id;
                    Session["Username"] = auth.Username;
                    return RedirectToAction("Index", "Products_List");
                }
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
            }

            ModelState.AddModelError("", "You Entered Wrong login Credentials");
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(Users model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Users.Add(model);
                    db.SaveChanges();
                    FormsAuthentication.SetAuthCookie(model.Username, false);
                    Log.Info("Signup SuccessFul");
                    return RedirectToAction("Login");
                }
                catch (Exception e)
                {
                    Log.Error(e.ToString());
                    ModelState.AddModelError("", "Exception is " + e.ToString());
                }

            }
            return View();

        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}