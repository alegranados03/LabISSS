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
    public partial class Menu_Establecimiento : Form
    {
        public Menu_Establecimiento()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Manager vnt3 = new Menu_Manager();
            vnt3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Establecimientos_ISSS vnt1 = new Establecimientos_ISSS();
            vnt1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agregar_Establecimiento vnt0 = new Agregar_Establecimiento();
            vnt0.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Establecimientos_MINSAL vnt2 = new Establecimientos_MINSAL();
            vnt2.Show();
        }
    }
}
