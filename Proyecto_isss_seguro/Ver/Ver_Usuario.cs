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
    public partial class Ver_Usuario : Form
    {
        Clases.Conexion con = new Clases.Conexion();
        public Ver_Usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Ver_Usuario_Load(object sender, EventArgs e)
        {
            try
            {
                if (con.conectar() == true)
                {
                    listarusuarios(con.conexion);

                }

            }
            catch (MySqlException ex)
            {
                throw ex;
            }

            con.desconectar();
        }


        public void listarusuarios(MySqlConnection conect)
        {

            Clases.User.listarUsuarios(conect, dataGridView1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Muestra vnt0 = new Menu_Muestra();
            vnt0.Show();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            con.conectar();

            MySqlCommand cmd = con.conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuario where NOMBRES like('" + textBox1.Text + "%') or APELLIDOS like('" + textBox1.Text + "%') or USUARIO like('" + textBox1.Text + "%') or TIPOUSUARIO like('" + textBox1.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            con.desconectar();
        }
    }
}
