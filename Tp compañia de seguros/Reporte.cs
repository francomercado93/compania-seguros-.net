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
                using (var conexion = Conexion.ObtenerConexion())
                {
                    using (var comando = new MySqlCommand(consulta, conexion))
                    {
                        using (var respuesta = comando.ExecuteReader())
                        {
                            while (respuesta.Read())
                            {
                                comboMedidas.Refresh();
                                comboMedidas.Items.Add(respuesta.GetValue(0).ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        public void CargarComboRiesgos()
        {
            string consulta = "select Descripcion from riesgo;";
            try
            {
                using (var conexion = Conexion.ObtenerConexion())
                {
                    using (var comando = new MySqlCommand(consulta, conexion))
                    {
                        using (var respuesta = comando.ExecuteReader())
                        {
                            while (respuesta.Read())
                            {
                                comboRiesgo.Refresh();
                                comboRiesgo.Items.Add(respuesta.GetValue(0).ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        public void CargarComboEstados()
        {
            string consulta = "select Descripcion from estado;";
            try
            {
                using (var conexion = Conexion.ObtenerConexion())
                {
                    using (var comando = new MySqlCommand(consulta, conexion))
                    {
                        using (var respuesta = comando.ExecuteReader())
                        {
                            checkedListBoxEstado.Items.Add("Todos");
                            while (respuesta.Read())
                            {
                                checkedListBoxEstado.Refresh();
                                checkedListBoxEstado.Items.Add(respuesta.GetValue(0).ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void Reporte_Load(object sender, EventArgs e)
        {
            this.CargarComboMedidas();
            this.CargarComboRiesgos();
            this.CargarComboEstados();
            //checkedListBoxEstado.SetItemChecked(0, true);

        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            dataGridViewReporte.DataSource = this.TablaReporte();
            //checkedListBoxEstado.ClearSelected();
        }

        public DataTable TablaReporte()
        {
            DataTable tablaReporte = new DataTable();

            try
            {
                MySqlConnection conexion = Conexion.ObtenerConexion();
                MySqlCommand comando = new MySqlCommand("tablaReporte", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                this.faltaSeleccionarCombo();
                if (comboMedidas.SelectedItem != null)
                {
                    comando.Parameters.AddWithValue("@medidaSeleccionada", comboMedidas.SelectedItem.ToString());
                }
                else
                {
                    comando.Parameters.AddWithValue("@medidaSeleccionada", null);

                }
                if (comboRiesgo.SelectedItem != null)
                {
                    comando.Parameters.AddWithValue("@riesgoSeleccionado", comboRiesgo.SelectedItem.ToString());
                }
                else
                {
                    comando.Parameters.AddWithValue("@riesgoSeleccionado", null);
                }
                comando.Parameters.AddWithValue("@valorMin", numericUpDownMin.Value);
                comando.Parameters.AddWithValue("@valorMax", numericUpDownMax.Value);
                comando.Parameters.AddWithValue("@estadoSeleccionado", checkedListBoxEstado.SelectedItem.ToString());
                tablaReporte.Load(comando.ExecuteReader());

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return tablaReporte;
        }


        public void faltaSeleccionarCombo()
        {
            if (checkedListBoxEstado.CheckedItems.Count == 0)
            {
                throw new Exception("Debe seleccionar un opcion para el estado del seguro.");
            }

        }

        private void checkedListBoxEstado_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBoxEstado.Items.Count; ++ix)
                if (ix != e.Index) checkedListBoxEstado.SetItemChecked(ix, false);
        }

        static class Constants
        {
            public const decimal MAX = 10000000;
            public const decimal MIN = 0;
        }

        private void buttonCleanRiesgos_Click(object sender, EventArgs e)
        {
            comboRiesgo.SelectedItem = null;
        }

        private void buttonCleanMed_Click(object sender, EventArgs e)
        {
            comboMedidas.SelectedItem = null;
        }
    }
}
