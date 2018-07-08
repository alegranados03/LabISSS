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
    public partial class Ver_Prueba : Form
    {
        public Ver_Prueba()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Prueba vnt0 = new Menu_Prueba();
            vnt0.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ver_Prueba_ADA vnt1 = new Ver_Prueba_ADA();
            vnt1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ver_Prueba_BK vnt2 = new Ver_Prueba_BK();
            vnt2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ver_Prueba_Baar vnt3 = new Ver_Prueba_Baar();
            vnt3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ver_Prueba_GX vnt0 = new Ver_Prueba_GX();
            vnt0.Show();
        }
    }
}
