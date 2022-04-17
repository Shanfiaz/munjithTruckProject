using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrieghtTransportAssociation.Controllers
{
    public class UserManagmentController : Controller
    {
        // GET: UserManagment
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddUser()
        {
            return View();
        }
        public ActionResult EditUser()
        {
            return View();
        }
    }
}