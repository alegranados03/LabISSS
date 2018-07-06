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
    public partial class Establecimientos_MINSAL : Form
    {
        Clases.Conexion con = new Clases.Conexion();
        public Establecimientos_MINSAL()
        {
            InitializeComponent();
        }

        private void Establecimientos_MINSAL_Load(object sender, EventArgs e)
        {
            try
            {
                if (con.conectar() == true)
                {
                    listarminsal(con.conexion);

                }

            }
            catch (MySqlException ex)
            {
                throw ex;
            }

            con.desconectar();
        }

        public void listarminsal(MySqlConnection conect)
        {

            Clases.Establecimiento.listarEstablecimientosMINSAL(conect, dataGridView1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Establecimiento vnt0 = new Menu_Establecimiento();
            vnt0.Show();
        }
    }
}
