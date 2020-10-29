using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ferreteria.Models
{
    public class Articulos
    {
        public int Id_Articulo { get; set; }
        public string Nombre_Articulo { get; set; }
        public float Costo { get; set; }       
        public float Precio_Unidad { get; set; }
        public float Precio_medidad { get; set; }
        public int Medida { get; set; }
        public int Id_Marca { get; set; }
        public string Descripcion { get; set; }
        public int Id_Movimiento { get; set; }
        public int Id_Proveedor { get; set; }



    }
}