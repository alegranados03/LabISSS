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
    public partial class Ingresar_Muestra : Form
    {
        Clases.Conexion con = new Clases.Conexion();
        public Ingresar_Muestra()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (con.conectar() == true)
                {

                    comboBox1.DataSource = Clases.Establecimiento.cargarestablecimientosrefamot(con.conexion);
                    comboBox1.DisplayMember = "nombreEstablecimiento";
                    comboBox1.ValueMember = "idEstablecimiento";
                    con.desconectar();
                    con.conectar();
                    comboBox2.DataSource = Clases.Establecimiento.cargarestablecimientoscultamot(con.conexion);
                    comboBox2.DisplayMember = "nombreEstablecimiento";
                   comboBox2.ValueMember = "idEstablecimiento";
                    con.desconectar();
                    con.conectar();
                    cbTipoMuestra.DataSource = Clases.TipoMuestra.cargarCbTipoMuestra(con.conexion);
                    cbTipoMuestra.DisplayMember = "nombreTipoMuestra";
                    cbTipoMuestra.ValueMember = "idTipoMuestra";
                }

            }
            catch (MySqlException ex)
            {
                throw ex;
            }

            con.desconectar();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxafiliacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttoncancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonguardar_Click(object sender, EventArgs e)
        {
            Clases.Muestra mu = new Clases.Muestra(Convert.ToInt32(comboBox1.ValueMember), Convert.ToInt32(label7.Text),dateTimePicker2.Text,textBoxObservacion.Text, Convert.ToInt32(comboBox1.ValueMember), Convert.ToInt32(comboBox2.ValueMember));
            Clases.Muestra.insertarMuestra(con.conexion,mu);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
