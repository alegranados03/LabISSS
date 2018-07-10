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
    public partial class Menu_Muestra : Form
    {
        public Menu_Muestra()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Manager vnt0 = new Menu_Manager();
            vnt0.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ingresar_Muestra vnt1 = new Ingresar_Muestra();
            vnt1.Show();
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ver_Muestra vnt2 = new Ver_Muestra();
            vnt2.Show();
        }
    }
}
