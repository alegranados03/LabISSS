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
    public partial class Actualizar_Muestra : Form
    {
        Clases.Conexion con = new Clases.Conexion();
        public Actualizar_Muestra()
        {
            InitializeComponent();
        }

        private void buttoncancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ver.Expediente vnt0 = new Ver.Expediente();
            vnt0.Show();
        }

        private void buttonguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.conectar())
                {
                    Clases.Muestra mu = new Clases.Muestra(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(label7.Text), dateTimePicker2.Value.ToString(), textBoxObservacion.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue));
                    Clases.Muestra.actualizarMuestra(con.conexion, mu);
                    MessageBox.Show("Muestra Actualizada Exitosamente");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al actualizar la muestra" + ex);
            }
            con.desconectar();
        }
    }
}
