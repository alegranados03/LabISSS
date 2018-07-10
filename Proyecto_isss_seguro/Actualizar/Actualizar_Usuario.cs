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
    public partial class Actualizar_Usuario : Form
    {
        Clases.Conexion con = new Clases.Conexion();
        public Actualizar_Usuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ver_Usuario vnt0 = new Ver_Usuario();
            vnt0.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.User pac = new Clases.User(Convert.ToInt32(label6.Text), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, CmbCargo2.Text);
            try
            {
                if (con.conectar())
                {
                    Clases.User.actualizarUsuario(con.conexion, pac);
                    MessageBox.Show("Usuario actualizado exitosamente");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    CmbCargo2.Text = "";
                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error es probable que el número de afiliación ya esté registrado" + ex);
            }
            con.desconectar();
        }
    }
}
