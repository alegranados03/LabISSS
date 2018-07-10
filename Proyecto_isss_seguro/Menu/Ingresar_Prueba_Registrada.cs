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
    public partial class Ingresar_Prueba_Registrada : Form
    {
        public Ingresar_Prueba_Registrada()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ingresar_Prueba_BK vnt0 = new Ingresar_Prueba_BK();
            vnt0.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ingreso_Prueba_Baar vnt1 = new Ingreso_Prueba_Baar();
            vnt1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ingresar_Prueba_ADA vnt2 = new Ingresar_Prueba_ADA();
            vnt2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ingreso_Prueba_GX vnt3 = new Ingreso_Prueba_GX();
            vnt3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ingresar_Prueba vnt4 = new Ingresar_Prueba();
            vnt4.Show();
        }
    }
}
