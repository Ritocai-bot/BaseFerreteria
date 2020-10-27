using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ferreteria.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios     
        public ActionResult Leer()
        {
            return View();
        }

        public ActionResult Crear()
        {
            return View();
        }
    }
}    