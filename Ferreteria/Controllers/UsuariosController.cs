using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ferreteria.Models;

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
        
                
        public ActionResult Editar(int id)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Nombre_Usuario = "Jose Maria";
            usuarios.Telefono = "78787878";
            ViewBag.Nombre = "jose";
            return View ();
        }
      

        [HttpPost]
        public ActionResult InsertarUsuario(Usuarios u)
        {
            u.Id_Usuario = '2';
            u.Nombre_Usuario = "Juan";
            return RedirectToAction("Leer");
        }

        [HttpPost]
        public ActionResult EditarUsuario(Usuarios u)
        {
            u.Id_Usuario = '2';
            u.Nombre_Usuario = "Juan";
            return RedirectToAction("Leer");
        }
    }
}    