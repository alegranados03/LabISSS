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
    public partial class Agregar_Usuario : Form
    {
        Clases.Conexion con = new Clases.Conexion();
        
        public Agregar_Usuario()
        {
            InitializeComponent();
            CmbCargo2.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Usuario vnt0 = new Menu_Usuario();
            vnt0.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.User us = new Clases.User(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, CmbCargo2.Text);
            try {
                if (con.conectar()) {
                    Clases.User.insertarUsuario(con.conexion,us);
                    MessageBox.Show("Usuario registrado exitosamente");
                }
            

            } catch(MySqlException ex) {
                
                MessageBox.Show("error es probable que el usuario ya esté registrado"+ex);
            }

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            CmbCargo2.Text = "";
            con.desconectar();
        }

        private void CmbCargo2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_Usuario_Load(object sender, EventArgs e)
        {

        }
    }
}
