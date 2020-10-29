using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ferreteria.Controllers
{
    public class VentasController : Controller
    {
        // GET: Ventas
        public ActionResult Ventas_Articulos()
        {
            return View();
        }
    }
}