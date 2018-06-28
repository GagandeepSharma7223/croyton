using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CroytonStoreFront.Models;
using CroytonStoreFront.Repositories;

namespace CroytonStoreFront.Controllers
{

    public class HomeController : Controller
    {
        #region Properties
        public readonly ContactFormRerpository formRerpository = null;
        #endregion

        #region Ctor
        public HomeController()
        {
            formRerpository = new ContactFormRerpository();
        }

        #endregion

        #region Actions
        public ActionResult Index()
        {
            return View(new ContactFormViewModel());
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult SaveContactForm(ContactFormViewModel model)
        {
            bool toReturn= false;
            if (ModelState.IsValid)
            {
                if (formRerpository.InsertContactInformation(model))
                {
                    toReturn = true;

                } 
            }
            return Json(new { data = toReturn }, JsonRequestBehavior.AllowGet);
        }

        #endregion

    }
}