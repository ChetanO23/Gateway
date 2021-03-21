using Assignment_1_DB_First.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_1_DB_First.Controllers
{
    public class AddressesViewController : Controller
    {
        // GET: AddressesView
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult viewaddresses()
        {
            ViewBag.Message = "User's Addresses Details";
            CRUD_OP_Training_SessionEntities db = new CRUD_OP_Training_SessionEntities();
            List<Address> addresslist = db.Addresses.ToList();
            AddressesViewModel avm = new AddressesViewModel();
            List<AddressesViewModel> avmlist = addresslist.Select(x => new AddressesViewModel

            {
                ID = x.ID,
                USER_NAME = x.User.USER_NAME,
                USER_ID=x.USER_ID,
                ADDRESS_TYPE=x.ADDRESS_TYPE,
                ADDRESS_VALUE=x.ADDRESS_VALUE
            }


            ).ToList();


            return View(avmlist);
        }
    }
}