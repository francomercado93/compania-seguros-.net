using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_compañia_de_seguros
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.ObtenerConexion();
                MessageBox.Show("Conexion exitosa");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Estadisticas().ShowDialog();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Reporte().ShowDialog();
        }
    }
}
