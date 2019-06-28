using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArgenClima.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "ArgenClima";
            ViewBag.Message = "Nosotros te avisamos";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Quienes somos";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contactenos";

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Registrate para tener todos nuestros beneficios";

            return View();
        }
    }
}