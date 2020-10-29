using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ferreteria.Models;

namespace Ferreteria.Controllers
{
    public class ArticulosController : Controller
    {
        // GET: Articulos
        public ActionResult Leer()
        {
            return View();
        }


        public ActionResult Crear()
        {
            return View();
        }


        public ActionResult Editar(int id)
        {
            Articulos articulos = new Articulos();            
            ViewBag.Nombre = "jose";
            return View();
        }


        [HttpPost]
        public ActionResult InsertarArticulo(Articulos a)
        {            
            return RedirectToAction("Leer");
        }

        [HttpPost]
        public ActionResult EditarArticulo(Articulos a)
        {            
            return RedirectToAction("Leer");
        }
    }
}
