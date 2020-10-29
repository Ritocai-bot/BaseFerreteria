using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ferreteria.Clases;

namespace Ferreteria.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Sesiones s = new Sesiones();
            if (true)
            {                
                s.SesionesUsuario = "Hola";                
            }
            else
            {
                s.SesionesUsuario = "Adios";           
            }
            return View(s);
        }
        
        public ActionResult Login()
        {
            return View();
        }
    }
}