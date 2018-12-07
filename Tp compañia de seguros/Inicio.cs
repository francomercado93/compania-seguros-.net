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

        private void EstadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Estadisticas().ShowDialog();
        }

        private void ReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Reporte().ShowDialog();
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login formLogin = new Login();
            formLogin.Show();
        }

        private void BotonAnular_Click(object sender, EventArgs e)
        {
                new AnularSeguro().ShowDialog();
        }
    }
}
