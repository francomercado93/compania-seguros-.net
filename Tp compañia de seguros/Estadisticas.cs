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
            this.TablaMedidasSeguridad();
            this.TablaRiesgos();
            
        }

        public void TablaMedidasSeguridad()
        {

            listViewMedidas.GridLines = true;
            listViewMedidas.View = View.Details;

            listViewMedidas.Columns.Add("Medidas de seguridad", 150);
            listViewMedidas.Columns.Add("Cantidad de seguros", 150);
            string query = "select ms.Descripcion, count(*) as Cantidad from cuentacon cc inner join medidaseguridad ms on cc.id_med_seguridad = ms.idMedidaSeguridad group by cc.id_med_seguridad";
            try
            {
                using (var conexion = Conexion.ObtenerConexion())
                {
                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        using (var reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader.GetString(0));
                                item.SubItems.Add(reader.GetString(1));
                                listViewMedidas.Items.Add(item);

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

        public void TablaRiesgos()
        {
            listViewRiesgos.GridLines = true;
            listViewRiesgos.View = View.Details;

            listViewRiesgos.Columns.Add("Riesgos", 150);
            listViewRiesgos.Columns.Add("Cantidad de seguros", 150);

            string query = "select r.Descripcion, count(*) as Cantidad from cubre c inner join riesgo r on c.idRiesgo = r.idRiesgo group by c.idRiesgo;";
            try
            {
                using (var conexion = Conexion.ObtenerConexion())
                {
                    using (var comando = new MySqlCommand(query, conexion))
                    {
                        using (var reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader.GetString(0));
                                item.SubItems.Add(reader.GetString(1));
                                listViewRiesgos.Items.Add(item);

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

 

    }
}
