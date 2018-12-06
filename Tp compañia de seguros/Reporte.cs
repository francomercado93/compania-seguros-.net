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
        public void CargarComboEstados()
        {
            string consulta = "select Descripcion from estado;";
            try
            {
                MySqlConnection conexion = Conexion.ObtenerConexion();
                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                MySqlDataReader respuesta = comando.ExecuteReader();
                checkedListBoxEstado.Items.Add("Todos");
                while (respuesta.Read())
                {
                    checkedListBoxEstado.Refresh();
                    checkedListBoxEstado.Items.Add(respuesta.GetValue(0).ToString());
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
            this.CargarComboEstados();
            checkedListBoxEstado.SetItemChecked(0, true);

        }
        
        private void buscarButton_Click(object sender, EventArgs e)
        {
            dataGridViewReporte.DataSource = this.TablaReporte();
        }

        public DataTable TablaReporte()
        {
            DataTable tablaReporte = new DataTable();
            
            try
            {
                MySqlConnection conexion = Conexion.ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("tablaReporte", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                if (this.faltaSeleccionarCombos())
                {
                    throw new Exception("Debe seleccionar una medida de seguridad y/o un riesgo.");
                }
                comando.Parameters.AddWithValue("@estadoSeleccionado", checkedListBoxEstado.SelectedItem.ToString());
                comando.Parameters.AddWithValue("@medidaSeleccionada", comboMedidas.SelectedItem.ToString());
                comando.Parameters.AddWithValue("@riesgoSeleccionado", comboRiesgo.SelectedItem.ToString());
                if (numericUpDownMax.Value < Constants.MIN || numericUpDownMax.Value > Constants.MAX || numericUpDownMin.Value < Constants.MIN || numericUpDownMin.Value > Constants.MAX )
                {
                    throw new Exception("Debe ingresar valores minimos y maximos validos");
                }
                comando.Parameters.AddWithValue("@valorMin", numericUpDownMin.Value);
                comando.Parameters.AddWithValue("@valorMax", numericUpDownMax.Value);
                tablaReporte.Load(comando.ExecuteReader());

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return tablaReporte;
        }


        public Boolean faltaSeleccionarCombos()
        {
            return comboMedidas.SelectedItem == null || comboRiesgo.SelectedItem == null;
        }

        private void checkedListBoxEstado_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBoxEstado.Items.Count; ++ix)
                if (ix != e.Index) checkedListBoxEstado.SetItemChecked(ix, false);
        }

        static class Constants
        {
            public const decimal MAX = 100000000000000;
            public const decimal MIN = 0;
        }

    }
}
