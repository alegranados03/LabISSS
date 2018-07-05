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
            Clases.Establecimiento pac = new Clases.Establecimiento();
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
    }
}
