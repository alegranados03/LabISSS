using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_isss_seguro
{
    public partial class Ingresar_Prueba : Form
    {
        public Ingresar_Prueba()
        {
            InitializeComponent();
        }

        private void Ingresar_Prueba_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Prueba vnt2 = new Menu_Prueba();
            vnt2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrar_Prueba vnt0 = new Registrar_Prueba();
            vnt0.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ingresar_Prueba_Registrada vnt1 = new Ingresar_Prueba_Registrada();
            vnt1.Show();
        }
    }
}
