using ArgenClima.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArgenClima.Controllers
{
    public class UsersController : Controller
    {

        private UsersContext _context;

        public UsersController()
        {
            _context = new UsersContext();
        }
        // GET: Users/Login
        public ActionResult Login()
        {
            /*var users = _context.Usuarios.ToList();
            PruebaUserViewModel p = new PruebaUserViewModel(users);
            if (users != null)
                return View(p);
            else return Content("no hay usuarios");*/
            return View();
        }

        public ActionResult Perfil()
        {
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }

    internal class PruebaUserViewModel
    {
        public PruebaUserViewModel(List<User> users)
        {
        }
    }
}