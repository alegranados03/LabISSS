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

namespace Proyecto_isss_seguro.Ver
{
    public partial class Expediente : Form
    {   Clases.Conexion con = new Clases.Conexion();

        public Expediente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ver_Paciente vnt1 = new Ver_Paciente();
            vnt1.Show();
        }

        private void Expediente_Load(object sender, EventArgs e)
        {
            try
            {
                if (con.conectar() == true)
                {
                    listarmuestras(con.conexion);

                }

            }
            catch (MySqlException ex)
            {
                throw ex;
            }

            con.desconectar();

        }

        public void listarmuestras(MySqlConnection conect)
        {

            Clases.Muestra.listarMuestras(conect,label3.Text, dataGridView1);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Ingresar_Muestra vnt2 = new Ingresar_Muestra();
            vnt2.label7.Text = label3.Text; 

            vnt2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ver.expedientemuestra vnt0 = new expedientemuestra();
            vnt0.Show();
        }
    }
}
