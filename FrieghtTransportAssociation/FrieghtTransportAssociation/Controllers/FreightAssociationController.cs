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


        public ActionResult LogInForm()
        {
            return View();
        }
        public ActionResult FreightEditUserForm()
        {
            return View();
        }

        public ActionResult FreightUserListingForm()
        {
            return View();
        }

        public ActionResult FreightUserInfoForm()
        {
            return View();
        }


    
    }
}