using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ferreteria.Models
{
    public class Proveedores
    {
        public int Id_Proveedor { get; set; }
        public string Nombre_Proveedor { get; set; }
        public string Nombre_Contacto { get; set; }
        public string Correo_Proveedor { get; set; }
        public int Telefono_Proveedor { get; set; }
    }
}