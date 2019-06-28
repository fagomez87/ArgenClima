using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArgenClima.Controllers
{
    public class PreferencesController : Controller
    {
        // GET: Preferences
        public ActionResult Preferences()
        {
            return View();
        }
    }
}