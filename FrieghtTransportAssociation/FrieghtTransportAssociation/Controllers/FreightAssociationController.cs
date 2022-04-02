using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrieghtTransportAssociation.Controllers
{
    public class FreightAssociationController : Controller
    {
        // GET: FreightAssociation
        public ActionResult FreightAssociation()
        {
            return View();
        }
        public ActionResult FreightAddForm()
        {
            return View();
        }
        public ActionResult FreightEditForm()
        {
            return View();
        }
    }
}