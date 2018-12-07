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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BotonIngresar_Click(object sender, EventArgs e)
        {
            string user = UsuarioTextBox.Text;
            string pass = PasswordTextBox.Text;

            try
            {
                ValidarDatosLogin(user, pass);

                string consultaLogin = "SELECT COUNT(*) FROM AGENTE WHERE idAgente = @user AND DNI = @pass";
                MySqlConnection conexion = Conexion.ObtenerConexion();
                MySqlCommand comando = new MySqlCommand(consultaLogin, conexion);
                comando.Parameters.AddWithValue("@user", user);
                comando.Parameters.AddWithValue("@pass", pass);

                if (comando.ExecuteScalar().ToString() == "1")
                {
                    this.Hide();
                    Inicio formInicio = new Inicio();
                    formInicio.Show();
                }
                else
                {
                    MessageBox.Show("Error al ingresar!", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ValidarDatosLogin(string user, string pass)
        {
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Ingresar usuario!");
                throw new Exception("Ingresar usuario!");
            }

            if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Ingresar password!");
                throw new Exception("Ingresar password!");
            }

        }
    }
}
