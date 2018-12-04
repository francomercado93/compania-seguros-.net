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
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }


        public void CargarComboMedidas()
        {
            string consulta = "select Descripcion from medidaseguridad;";
            try
            {
                MySqlConnection conexion = Conexion.ObtenerConexion();
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                MySqlDataReader respuesta = comando.ExecuteReader();

                while (respuesta.Read())
                {
                    comboMedidas.Refresh();
                    comboMedidas.Items.Add(respuesta.GetValue(0).ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        public void CargarComboRiesgos()
        {
            string consulta = "select Descripcion from riesgo;";
            try
            {
                MySqlConnection conexion = Conexion.ObtenerConexion();
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                MySqlDataReader respuesta = comando.ExecuteReader();

                while (respuesta.Read())
                {
                    comboRiesgo.Refresh();
                    comboRiesgo.Items.Add(respuesta.GetValue(0).ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            this.CargarComboMedidas();
            this.CargarComboRiesgos();
            
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
           
            reporteDVT.DataSource = this.TablaReporte();
        }

        public DataTable TablaReporte()
        {
            DataTable dgv = new DataTable();
            string consultaBase = "select h.*, ms.Descripcion from hogar h inner join cuentacon cc on h.idSeguro = cc.id_seguro_hogar inner join  medidaseguridad ms on cc.id_med_Seguridad = ms.idMedidaSeguridad where ms.Descripcion = ";
            string consulta = String.Concat(consultaBase, "'", comboMedidas.SelectedItem.ToString(), "'");
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
