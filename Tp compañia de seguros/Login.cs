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
                    throw new Exception("Error al ingresar!");
                }
                conexion.Close();
            }
            catch (Exception error)
            {
                //MessageBox.Show("", MessageBoxIcon.Error);
                MessageBox.Show(error.Message, "Error al ingresar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarDatosLogin(string user, string pass)
        {
            if (string.IsNullOrEmpty(user))
            {
                
                throw new Exception("Ingresar usuario!");
            }

            if (string.IsNullOrEmpty(pass))
            {
               
                throw new Exception("Ingresar password!");
            }

        }
    }
}
