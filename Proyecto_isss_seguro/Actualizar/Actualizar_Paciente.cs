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
    public partial class Actualizar_Paciente : Form
    {
        Clases.Conexion con = new Clases.Conexion();
        public Actualizar_Paciente()
        {
            InitializeComponent();
        }

        private void buttoncancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ver_Paciente vnt0 = new Ver_Paciente();
            vnt0.Show();
        }

        private void buttonguardar_Click(object sender, EventArgs e)
        {
            Clases.Paciente pac = new Clases.Paciente(Convert.ToInt32(label11.Text), textBoxafiliacion.Text, textBoxnombres.Text, textBoxapellidos.Text, textBoxdireccion.Text, comboBoxgruposanguineo.Text, comboBoxfactorrh.Text, comboBoxgenero.Text, textBoxvih.Text, Convert.ToInt32(textBoxedad.Text), textBoxtelefono.Text);
            try
            {
                if (con.conectar())
                {
                    Clases.Paciente.actualizarPaciente(con.conexion, pac);
                    MessageBox.Show("Paciente actualizado exitosamente");
                    textBoxafiliacion.Text = "";
                    textBoxnombres.Text = "";
                    textBoxapellidos.Text = "";
                    textBoxdireccion.Text = "";
                    comboBoxgruposanguineo.Text = "";
                    comboBoxfactorrh.Text = "";
                    comboBoxgenero.Text = "";
                    textBoxvih.Text = "";
                    textBoxedad.Text = "";
                    textBoxtelefono.Text = "";
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
