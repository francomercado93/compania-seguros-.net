using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tp_compañia_de_seguros
{
    public partial class AnularSeguro : Form
    {
        public AnularSeguro()
        {
            InitializeComponent();
        }

        private void AnularSeguro_Load(object sender, EventArgs e)
        {
            this.CargarAgentes();
            this.CargarClientes();
            this.CargarEstados();
            this.CargarTipoSeguro();
        }

        private void CargarTipoSeguro()
        {
            try
            {
                TipoSegComboBox.DisplayMember = "Text";
                TipoSegComboBox.ValueMember = "Value";
                TipoSegComboBox.Items.Add(new { Text = "Hogar", Value = "H" });
                TipoSegComboBox.Items.Add(new { Text = "Vida", Value = "V" });
                TipoSegComboBox.Items.Add(new { Text = "Automovil", Value = "A" });
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar Estados!");
                throw;
            }
        }

        private void CargarEstados()
        {
            try
            {
                using (var conexion = Conexion.ObtenerConexion())
                {
                    var consultaLogin = "SELECT idEstado, Descripcion FROM ESTADO";
                    using (var command = new MySqlCommand(consultaLogin, conexion))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            EstadoSegComboBox.DisplayMember = "Text";
                            EstadoSegComboBox.ValueMember = "Value";
                            while (reader.Read())
                            {
                                EstadoSegComboBox.Items.Add(new { Text = reader.GetString("Descripcion"), Value = reader.GetString("idEstado") });
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar Estados!");
                throw;
            }
        }

        private void CargarAgentes()
        {
            try
            {
                using (var conexion = Conexion.ObtenerConexion())
                {
                    var consultaLogin = "SELECT idAgente, Nombre, Apellido FROM AGENTE";
                    using (var command = new MySqlCommand(consultaLogin, conexion))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            AgenteComboBox.DisplayMember = "Text";
                            AgenteComboBox.ValueMember = "Value";
                            while (reader.Read())
                            {
                                string nombreCompleto = reader.GetString("Nombre") + " " + reader.GetString("Apellido");
                                AgenteComboBox.Items.Add(new { Text = nombreCompleto, Value = reader.GetString("idAgente") });
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar Agentes!");
                throw;
            }
        }

        private void CargarClientes()
        {
            try
            {
                using (var conexion = Conexion.ObtenerConexion())
                {
                    var consultaLogin = "SELECT idTomador, Nombre, Apellido FROM TOMADOR";
                    using (var command = new MySqlCommand(consultaLogin, conexion))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            ClienteComboBox.DisplayMember = "Text";
                            ClienteComboBox.ValueMember = "Value";
                            while (reader.Read())
                            {
                                string nombreCompleto = reader.GetString("Nombre") + " " + reader.GetString("Apellido");
                                ClienteComboBox.Items.Add(new { Text = nombreCompleto, Value = reader.GetString("idTomador") });
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar Clientes!");
                throw;
            }
        }

        private void PolizaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            this.CargarDataGrid();
            this.CustomGrid();
        }

        private void CustomGrid()
        {
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            if (SegurosDataGridView.Columns["Anular"] == null)
            {
                checkColumn.Name = "Anular";
                checkColumn.HeaderText = "Anular";
                checkColumn.ReadOnly = false;
                SegurosDataGridView.Columns.Add(checkColumn);
            }

            foreach (DataGridViewColumn dc in SegurosDataGridView.Columns)
            {
                if (dc.HeaderText == "Anular")
                {
                    dc.ReadOnly = false;
                }
                else
                {
                    dc.ReadOnly = true;
                }
            }
        }

        private void CargarDataGrid()
        {
            try
            {
                using (var conexion = Conexion.ObtenerConexion())
                {
                    using (var command = new MySqlCommand("buscarSeguros", conexion))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        DataTable tablaSeguros = new DataTable();

                        if (PolizaTextBox.Text == string.Empty)
                        {
                            command.Parameters.AddWithValue("@IdSeguro", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@IdSeguro", Convert.ToInt32(PolizaTextBox.Text));
                        }

                        if (ClienteComboBox.SelectedItem == null)
                        {
                            command.Parameters.AddWithValue("@IdTomador", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@IdTomador", Convert.ToInt32((ClienteComboBox.SelectedItem as dynamic).Value.ToString()));
                        }
                        if (AgenteComboBox.SelectedItem == null)
                        {
                            command.Parameters.AddWithValue("@IdAgente", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@IdAgente", Convert.ToInt32((AgenteComboBox.SelectedItem as dynamic).Value.ToString()));
                        }

                        command.Parameters.AddWithValue("@fechaInicio", InicioPicker.Value);
                        command.Parameters.AddWithValue("@fechaFin", FinalPicker.Value);

                        if (ContratacionPicker.Value.ToShortDateString() == "01/01/2018")
                        {
                            command.Parameters.AddWithValue("@fechaContratacion", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@fechaContratacion", ContratacionPicker.Value.Date);
                        }

                        if (TipoSegComboBox.SelectedItem == null)
                        {
                            command.Parameters.AddWithValue("@tipoSeguro", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@tipoSeguro", (TipoSegComboBox.SelectedItem as dynamic).Value.ToString());
                        }

                        if (EstadoSegComboBox.SelectedItem == null)
                        {
                            command.Parameters.AddWithValue("@estadoSeguro", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@estadoSeguro", Convert.ToInt32((EstadoSegComboBox.SelectedItem as dynamic).Value.ToString()));
                        }

                        tablaSeguros.Load(command.ExecuteReader());

                        SegurosDataGridView.DataSource = tablaSeguros;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar Seguros!");
                throw;
            }
        }

        private void AnularBoton_Click(object sender, EventArgs e)
        {
            List<int> segurosID = new List<int>();
            foreach (DataGridViewRow dc in SegurosDataGridView.Rows)
            {
                if (dc.Cells["Anular"].Value != null)
                {
                    if ((Boolean)dc.Cells["Anular"].Value == true)
                    {
                        segurosID.Add(Convert.ToInt32(dc.Cells["Seguro"].Value));
                    }
                }
            }

            this.AnularSeguros(segurosID);
        }

        private void AnularSeguros(List<int> segurosID)
        {
            try
            {
                using (var conexion = Conexion.ObtenerConexion())
                {
                    string ids = segurosID.Select(i => i.ToString(CultureInfo.InvariantCulture)).Aggregate((s1, s2) => s1 + ", " + s2);
                    string anularSeguros = string.Format("UPDATE SEGURO SET idEstado = 22204 WHERE idSeguro IN ({0})", ids);

                    using (var command = new MySqlCommand(anularSeguros, conexion))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                
            }

            this.CargarDataGrid();
        }
    }
}
