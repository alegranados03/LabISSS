using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Proyecto_isss_seguro
{
    public partial class Ingresar_Paciente : Form
    {
        Clases.Conexion con = new Clases.Conexion();
        Clases.Paciente paciente = new Clases.Paciente();
        public Ingresar_Paciente()
        {
            InitializeComponent();
        }

        private void buttonguardar_Click(object sender, EventArgs e)
        {
            Clases.Paciente pac = new Clases.Paciente(textBoxafiliacion.Text, textBoxnombres.Text, textBoxapellidos.Text, textBoxdireccion.Text, comboBoxgruposanguineo.Text, comboBoxfactorrh.Text, comboBoxgenero.Text, textBoxvih.Text, Convert.ToInt32(textBoxedad.Text), textBoxtelefono.Text);
            try
            {
                if (con.conectar())
                {
                    Clases.Paciente.insertarPaciente(con.conexion,pac);
                    MessageBox.Show("Paciente registrado exitosamente");
                }


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error es probable que el número de afiliación ya esté registrado");
            }


            con.desconectar();
        }
    }
}
