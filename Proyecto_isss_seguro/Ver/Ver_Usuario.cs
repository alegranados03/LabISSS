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

        public static String IdUsuario = null;
        public static string Nombres;
        public static string Apellidos;
        public static string Usuario;
        public static string Contraseña;
        public static string TipoUsuario;

        private void button1_Click(object sender, EventArgs e)
        {
            if (IdUsuario != null)
            {
                try
                {
                    if (con.conectar())
                    {
                        if (MessageBox.Show("¿Esta seguro que desea eliminar el usuario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Clases.User.EliminarUsuario(con.conexion, IdUsuario);
                            MessageBox.Show("Borrado exitosamente");
                        }
                    }

                }
                catch (MySqlException ex) { MessageBox.Show("Error al borrar"); }
                con.desconectar();


            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario");
            }
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
            Menu_Usuario vnt0 = new Menu_Usuario();
            vnt0.Show();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            con.conectar();

            MySqlCommand cmd = con.conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuario where NOMBRES like('" + textBox1.Text + "%') or APELLIDOS like('" + textBox1.Text + "%') or USUARIO like('" + textBox1.Text + "%')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            con.desconectar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IdUsuario != null)
            {
                this.Hide();
                Actualizar.Actualizar_Usuario vnt1 = new Actualizar.Actualizar_Usuario();
                vnt1.label6.Text = IdUsuario;
                vnt1.textBox1.Text = Nombres;
                vnt1.textBox2.Text = Apellidos;
                vnt1.textBox3.Text = Usuario;
               
                vnt1.CmbCargo2.Text = TipoUsuario;
                vnt1.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un paciente");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdUsuario = dataGridView1.Rows[e.RowIndex].Cells["IdUsuario"].Value.ToString();
            Nombres = dataGridView1.Rows[e.RowIndex].Cells["Nombres"].Value.ToString();
            Apellidos = dataGridView1.Rows[e.RowIndex].Cells["Apellidos"].Value.ToString();
            Usuario = dataGridView1.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();
            //Contraseña = dataGridView1.Rows[e.RowIndex].Cells["Contraseña"].Value.ToString();
            TipoUsuario = dataGridView1.Rows[e.RowIndex].Cells["TipoUsuario"].Value.ToString();
        }
    }
}
