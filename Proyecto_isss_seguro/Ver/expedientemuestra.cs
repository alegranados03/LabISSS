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

namespace Proyecto_isss_seguro.Ver
{
    public partial class expedientemuestra : Form
    {
        Clases.Conexion con = new Clases.Conexion();
        public expedientemuestra()
        {
            InitializeComponent();
        }

        public static String IdMuestra = null;
        public static string IdTipoDeMuestra;
        public static string IdPaciente;
        public static string Fecha;
        public static string ObservacionMuestra;
        public static string IdEstablecimientoRefe;
        public static string IdEstablecimientoCulti;

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ver.Expediente vnt0 = new Ver.Expediente();
            vnt0.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IdMuestra != null)
            {
                this.Hide();
                Actualizar.Actualizar_Muestra vnt2 = new Actualizar.Actualizar_Muestra();
                vnt2.label7.Text = IdPaciente;
                vnt2.comboBox1.Text = IdEstablecimientoRefe;
                vnt2.comboBox2.Text = IdEstablecimientoCulti;
                vnt2.cbTipoMuestra.Text = IdTipoDeMuestra;
                vnt2.textBoxObservacion.Text = ObservacionMuestra;
                vnt2.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un paciente");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdMuestra = dataGridView1.Rows[e.RowIndex].Cells["IdMuestra"].Value.ToString();
            IdTipoDeMuestra = dataGridView1.Rows[e.RowIndex].Cells["IdTipoDeMuestra"].Value.ToString();
            IdPaciente = dataGridView1.Rows[e.RowIndex].Cells["IdPaciente"].Value.ToString();
            Fecha = dataGridView1.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
            ObservacionMuestra = dataGridView1.Rows[e.RowIndex].Cells["ObservacionMuestra"].Value.ToString();
            IdEstablecimientoRefe = dataGridView1.Rows[e.RowIndex].Cells["IdEstablecimientoRefe"].Value.ToString();
            IdEstablecimientoCulti = dataGridView1.Rows[e.RowIndex].Cells["IdEstablecimientoCulti"].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ver_Prueba vnt0 = new Ver_Prueba();
            vnt0.Show();
        }
    }
}
