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
    public partial class Menu_Prueba : Form
    {
        public Menu_Prueba()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ingresar_Prueba vnt0 = new Ingresar_Prueba();
            vnt0.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ver_Prueba vnt1 = new Ver_Prueba();
            vnt1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Manager vnt2 = new Menu_Manager();
            vnt2.Show();
        }
    }
}
