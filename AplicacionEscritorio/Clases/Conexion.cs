using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* ----- Lineas creadas por mi ---- */
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AplicacionEscritorio
{
    public class Conexion
    {
        public static string ObtenerString()
        {
            return Properties.Settings.Default.pruebavisualConnectionString;
        }
        
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Conn = new SqlConnection(ObtenerString());
            Conn.Open();
            return Conn;
        }
    }
}
