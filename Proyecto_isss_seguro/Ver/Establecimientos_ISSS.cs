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

namespace Proyecto_isss_seguro
{
    public partial class Establecimientos_ISSS : Form
    {
        Clases.Conexion con = new Clases.Conexion();
        public Establecimientos_ISSS()
        {
            InitializeComponent();
        }

        public static String IdEstablecimiento;
        public static string IdEntidad;
        public static string IdRegion;
        public static string NombreEstablecimiento;
        public static string TipoEstablecimiento;
        public static string DireccionEstablecimiento;
        public static string TelefonoEstablecimiento;

        private void Establecimientos_ISSS_Load(object sender, EventArgs e)
        {
            try
            {
                if (con.conectar() == true)
                {
                    listarisss(con.conexion);

                }

            }
            catch (MySqlException ex)
            {
                throw ex;
            }

            con.desconectar();
        }


        public void listarisss(MySqlConnection conect)
        {

            Clases.Establecimiento.listarEstablecimientosISSS(conect, dataGridView1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Establecimiento vnt0 = new Menu_Establecimiento();
            vnt0.Show();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            con.conectar();

            MySqlCommand cmd = con.conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from establecimiento where IDENTIDAD like('1') and NOMBREESTABLECIMIENTO like('" + textBox1.Text + "%') or TIPOESTABLECIMIENTO like('" + textBox1.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            con.desconectar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdEstablecimiento = dataGridView1.Rows[e.RowIndex].Cells["IdEstablecimiento"].Value.ToString();
            IdEntidad = dataGridView1.Rows[e.RowIndex].Cells["IdEntidad"].Value.ToString();
            IdRegion = dataGridView1.Rows[e.RowIndex].Cells["IdRegion"].Value.ToString();
            NombreEstablecimiento = dataGridView1.Rows[e.RowIndex].Cells["NombreEstablecimiento"].Value.ToString();
            TipoEstablecimiento = dataGridView1.Rows[e.RowIndex].Cells["TipoEstablecimiento"].Value.ToString();
            DireccionEstablecimiento = dataGridView1.Rows[e.RowIndex].Cells["DireccionEstablecimiento"].Value.ToString();
            TelefonoEstablecimiento = dataGridView1.Rows[e.RowIndex].Cells["TelefonoEstablecimiento"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Actualizar.Actualizar_Establecimiento vnt1 = new Actualizar.Actualizar_Establecimiento();
            vnt1.label7.Text = IdEstablecimiento;
            vnt1.comboBox2.Text = cambiarEntidadString(IdEntidad);
            vnt1.comboBox1.Text = cambiarRegionString(IdRegion);
            vnt1.textBox3.Text = NombreEstablecimiento;
            vnt1.comboBox3.Text = TipoEstablecimiento;
            vnt1.textBox4.Text = DireccionEstablecimiento;
            vnt1.textBox5.Text = TelefonoEstablecimiento;
            vnt1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public static String cambiarRegionString(String idRegion)
        {
            String nomregion=null;
            if (idRegion == "1")
            {nomregion = "Zona Central";}

            else if (idRegion == "2")
            {  nomregion = "Zona Paracentral";}

            else if (idRegion == "3")
            { nomregion = "Zona Occidental";}

            else if (idRegion == "4")
            {nomregion = "Zona Oriental";}
            else if (idRegion == "5")
            {nomregion = "Zona Metropolitana";}

            else if (idRegion == "6")
            {nomregion = "Zona M. Unidades";}
            else if (idRegion == "7")
            {nomregion = "Zona M.Hospitales";}
            else
            {nomregion = "Otros";}
            return nomregion;
        }

        public static String cambiarEntidadString(String idEntidad)
        {
            String non = null;

            if (idEntidad == "1")
            {non = "ISSS";}
            else
            {non = "MINSAL";}
            return non;
        }
    }
}
