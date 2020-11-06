using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Ferreteria.Clases
{
    public class Conexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=ferreteria; Uid=root; pwd=; MinimumPoolSize=10; maximumpoolsize=500");
            conectar.Open();
            return conectar;
        }        
    }
}