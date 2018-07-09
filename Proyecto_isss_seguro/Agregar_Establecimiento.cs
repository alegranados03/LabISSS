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
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
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


            //ordenar bien el siguiente constructor para que los parámetros entren como corresponden
            Clases.Establecimiento pac = new Clases.Establecimiento(IDENTIDAD, IDREGION, textBox3.Text, comboBox3.Text, textBox4.Text, textBox5.Text);
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
                MessageBox.Show("error"+ex);
            }


            comboBox1.Text = " ";
            comboBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";


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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
