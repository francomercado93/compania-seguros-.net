using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tp_compañia_de_seguros
{
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
        }


        private void Estadisticas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.TablaMedidasSeguridad();
            dataGridView2.DataSource = this.TablaRiesgos();
        }

        public DataTable TablaMedidasSeguridad()
        {
            DataTable dgv = new DataTable();
            string estadisticasConsulta = "select ms.Descripcion, count(*) as Cantidad from cuentacon cc inner join medidaseguridad ms on cc.id_med_seguridad = ms.idMedidaSeguridad group by cc.id_med_seguridad";
            try
            {
                MySqlConnection conexion = Conexion.ObtenerConexion();
                MySqlCommand comando = new MySqlCommand(estadisticasConsulta, conexion);
                MySqlDataAdapter respuesta = new MySqlDataAdapter(comando);
                respuesta.Fill(dgv);

            }
            catch (Exception)
            {
                throw;
            }
            return dgv;
        }

        public DataTable TablaRiesgos()
        {
            DataTable dgv = new DataTable();
            string consulta = "select r.Descripcion, count(*) as Cantidad from cubre c inner join riesgo r on c.idRiesgo = r.idRiesgo group by c.idRiesgo;";
            try
            {
                MySqlConnection conexion = Conexion.ObtenerConexion();
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                MySqlDataAdapter respuesta = new MySqlDataAdapter(comando);
                respuesta.Fill(dgv);

            }
            catch (Exception)
            {
                throw;
            }
            return dgv;
        }

 

    }
}
