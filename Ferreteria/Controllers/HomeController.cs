using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ferreteria.Clases;
using MySql.Data.MySqlClient;

namespace Ferreteria.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(Sesiones s)
        {
            s = new Sesiones();
            if (Session["IdUsuario"] != null)
            {                
                return View(s);
            }
            else
            {
                s.NombreUsuario = "Vacio";
                return View(s);
            }                          
            
        }
        
        public ActionResult Login()
        {
            return View();
            

        }

        [HttpPost]
        public ActionResult VerificarLogin(FormCollection f)
        {
            Sesiones s = new Sesiones();           
            int Cod=0,cont=0, TipoUsu;
            string NombreUsu;           
                MySqlCommand cmdSeleccionar = new MySqlCommand();
                cmdSeleccionar.CommandText = "Select Id_Usuario,Nombre_Usuario,Tipo_Usuario From usuario Where Usuario='" + f["NameUser"] + "' And Password='" + f["Password"] +"'";
                cmdSeleccionar.Connection = Conexion.ObtenerConexion();
                MySqlDataReader reader = cmdSeleccionar.ExecuteReader();
                
                if (reader.Read())
                {
                    cont++;                                        
                    Session["IdUsuario"] = Cod = reader.GetInt32(0);
                    Session["NombreUsuario"] = NombreUsu = reader.GetString(1);
                    Session["TipoUsuario"] = TipoUsu = reader.GetInt32(2);                    
                }
                
                Conexion.ObtenerConexion().Close();
                if (cont>0)
                {
                    s.IdUsuario = (int)Session["IdUsuario"];
                    s.NombreUsuario = (string)Session["NombreUsuario"];
                    s.TipoUsuario = (int)Session["TipoUsuario"];
                    return RedirectToAction("Index",s);                    
                }
                else
                {
                    return RedirectToAction("Login");
                }                                    
                     
        }
    }
}