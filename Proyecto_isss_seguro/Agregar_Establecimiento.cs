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
    public partial class Agregar_Establecimiento : Form
    {
        Clases.Conexion con = new Clases.Conexion();
        public Agregar_Establecimiento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ordenar bien el siguiente constructor para que los parámetros entren como corresponden
            Clases.Establecimiento pac = new Clases.Establecimiento(Convert.ToInt32(comboBox1.Text), Convert.ToInt32(comboBox2.Text), textBox5.Text,textBox3.Text, textBox4.Text, textBox5.Text);
            try
            {
                if (con.conectar())
                {
                    Clases.Establecimiento.insertarEstablecimiento(con.conexion, pac);
                    MessageBox.Show("Establecimiento registrado exitosamente");
                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error");
            }



            con.desconectar();
        }

        private void Agregar_Establecimiento_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Establecimiento vnt0 = new Menu_Establecimiento();
            vnt0.Show();
        }
    }
}
