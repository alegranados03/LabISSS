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
    public partial class Ver_Paciente : Form
    {
       
        
        Clases.Conexion con = new Clases.Conexion();
        public Ver_Paciente()
        {
            InitializeComponent();

        }

        private void Ver_Paciente_Load(object sender, EventArgs e)
        {
            try
            {
                if (con.conectar() == true) {
                    listarpacientes(con.conexion);
                    
                }
                
            }
            catch (MySqlException ex) {
                throw ex;
            }

            con.desconectar();
        }

        public void listarpacientes(MySqlConnection conect)
        {
            
            Clases.Paciente.listarPacientes(conect,dataGridView1);
                      
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Paciente vnt0 = new Menu_Paciente();
            vnt0.Show();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            con.conectar();

            MySqlCommand cmd = con.conexion.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from paciente where IDPACIENTE like ('" + textBox1.Text + "') or NOAFILIACION like('" + textBox1.Text + "') or NOMBRE like('" + textBox1.Text + "') or APELLIDO like('" + textBox1.Text + "') or DIRECCION like('" + textBox1.Text + "') or GRUPOSANGUINEO like('" + textBox1.Text + "') or FACTORRH like('" + textBox1.Text + "') or GENERO like('" + textBox1.Text + "') or VIH like('" + textBox1.Text + "') or EDAD like('" + textBox1.Text + "') or TELEFONOPACIENTE like('" + textBox1.Text + "')";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            con.desconectar();
        }
    }
}
