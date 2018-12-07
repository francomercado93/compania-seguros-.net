using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Tp_compañia_de_seguros
{
    public class Conexion
    {

        public static MySqlConnection ObtenerConexion()
        {
            //MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=companiadesegurostp; Uid=root; pwd=root;");
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=companiadesegurostp; Uid=Fabian; pwd=123123123;");
            conectar.Open();

            return conectar;
        }
    }

}
