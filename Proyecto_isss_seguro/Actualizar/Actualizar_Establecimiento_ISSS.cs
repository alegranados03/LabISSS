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

namespace Proyecto_isss_seguro.Actualizar
{
    public partial class Actualizar_Establecimiento_ISSS : Form
    {
        Clases.Conexion con = new Clases.Conexion();
        public Actualizar_Establecimiento_ISSS()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Establecimientos_ISSS vnt0 = new Establecimientos_ISSS();
            vnt0.Show();
        }

        private void Actualizar_Establecimiento_ISSS_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IDREGION;
            int IDENTIDAD;

            if (comboBox1.Text == "Zona Central")
            {
                IDREGION = 1;
            }

            else if (comboBox1.Text == "Zona Paracentral")
            {
                IDREGION = 2;
            }

            else if (comboBox1.Text == "Zona Occidental")
            {
                IDREGION = 3;
            }

            else if (comboBox1.Text == "Zona Oriental")
            {
                IDREGION = 4;
            }
            else if (comboBox1.Text == "Zona Metropolitana")
            {
                IDREGION = 5;
            }

            else if (comboBox1.Text == "Zona M. Unidades")
            {
                IDREGION = 6;
            }
            else if (comboBox1.Text == "Zona M.Hospitales")
            {
                IDREGION = 7;
            }

            else
            {
                IDREGION = 8;
            }


            if (comboBox2.Text == "ISSS")
            {
                IDENTIDAD = 1;
            }

            else
            {
                IDENTIDAD = 2;
            }

            Clases.Establecimiento pac = new Clases.Establecimiento(Convert.ToInt32(label7.Text), IDENTIDAD, IDREGION, textBox3.Text, comboBox3.Text, textBox4.Text, textBox5.Text);
            try
            {
                if (con.conectar())
                {
                    Clases.Establecimiento.actualizarEstablecimiento(con.conexion, pac);
                    MessageBox.Show("Establecimiento actualizado exitosamente");
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    textBox3.Text = "";
                    comboBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }

            
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error es probable que el establecimiento ya esté registrado" + ex);
            }
            con.desconectar();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
