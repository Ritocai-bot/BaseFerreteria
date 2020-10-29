using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ferreteria.Models
{
    public class Usuarios
    {     
        public int Id_Usuario { get; set; }             
        public string Nombre_Usuario { get; set; }
        public string Telefono { get; set; }
        public string Usuario { get; set; }              
        public string Password { get; set; }
        public string Tipo_Usuario { get; set;  }
    }
}