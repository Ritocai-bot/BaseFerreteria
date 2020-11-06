using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ferreteria.Models;
using MySql.Data.MySqlClient;
using Ferreteria.Clases;

namespace Ferreteria.Controllers
{
    public class ProveedoresController : Controller
    {
        // Get Proveedores
        int Cod;
        public ActionResult Leer()
        {
            List<Proveedores> ListProveedor = new List<Proveedores>();
            ListProveedor = ListaProveedores();
            return View(ListProveedor);            
        }

        public List<Proveedores> ListaProveedores()
        {            
            List<Proveedores> ListP = new List<Proveedores>();
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "Select * From proveedor";
                cmd.Connection = Conexion.ObtenerConexion();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Proveedores p = new Proveedores();
                    p.Id_Proveedor = (int)reader[0];
                    p.Nombre_Proveedor = (String)reader[1];
                    p.Nombre_Contacto = (String)reader[2];
                    p.Correo_Proveedor = (String)reader[3];
                    p.Telefono_Proveedor = (int)reader[4];
                    ListP.Add(p);
                    
                }
                Conexion.ObtenerConexion().Close();
            }
            catch
            {

            }
            return ListP;

        }
        public ActionResult Crear()
        {
           return View();
        }

        public ActionResult Editar(int id)
        {
            //Proveedores proveedor = new Proveedores();
            //ViewBag.Nombre = "Master ink";
            
            return View(id);
        }

        [HttpPost]
        public ActionResult InsertarProveedor(FormCollection f)
        {
            Proveedores p = new Proveedores();
            p.Nombre_Proveedor = f["Nombre_Proveedor"];
            p.Nombre_Contacto = f["Nombre_Contacto"];
            p.Correo_Proveedor = f["Correo_Proveedor"];
            p.Telefono_Proveedor = Convert.ToInt32(f["Telefono_Proveedor"]);

            MySqlCommand cmdInsert = new MySqlCommand();
            cmdInsert.CommandText = "Insert Into proveedor (Id_Proveedor,Nombre_Proveedor,Nombre_Contacto,Correo_Proveedor,Telefono_Proveedor) Values (NULL,'" + p.Nombre_Proveedor + "', '" + p.Nombre_Contacto + "', '" + p.Correo_Proveedor + "','" + p.Telefono_Proveedor + "')";
            cmdInsert.Connection = Conexion.ObtenerConexion();
            cmdInsert.ExecuteNonQuery();
            Conexion.ObtenerConexion().Close();
            List<Proveedores> ListProveedor = new List<Proveedores>();
            ListProveedor = ListaProveedores();
            return RedirectToAction("Leer",ListProveedor);
        }

        [HttpPost]
        public ActionResult EditarProveedor(FormCollection a)
        {
            Proveedores p = new Proveedores();
            p.Nombre_Proveedor = a["EditarNombre_Proveedor"];
            p.Nombre_Contacto = a["EditarNombre_Contacto"];
            p.Correo_Proveedor = a["EditarCorreo_Proveedor"];
            p.Telefono_Proveedor = Convert.ToInt32(a["EditarTelefono_Proveedor"]);

            MySqlCommand cmdUpdate = new MySqlCommand();
            cmdUpdate.CommandText = "Update proveedor Set Nombre_Proveedor='Esto es una prueba' Where Id_Proveedor='" + p.Id_Proveedor + "' ";
            cmdUpdate.Connection = Conexion.ObtenerConexion();
            cmdUpdate.ExecuteNonQuery();
            Conexion.ObtenerConexion().Close();

            List<Proveedores> ListProveedor = new List<Proveedores>();
            ListProveedor = ListaProveedores();
            return RedirectToAction("Leer",ListProveedor);
        }
    }
};