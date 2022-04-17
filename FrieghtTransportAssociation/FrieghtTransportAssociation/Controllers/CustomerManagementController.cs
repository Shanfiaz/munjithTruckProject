using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrieghtTransportAssociation.Controllers
{
    public class CustomerManagementController : Controller
    {
        // GET: CustomerManagement
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddCustomer()
        {
            return View();
        }
        public ActionResult EditCustomer()
        {
            return View();
        }
    }
}