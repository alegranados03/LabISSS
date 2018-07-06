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
    }
}
