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
    public partial class Menu_Manager : Form
    {
        public Menu_Manager()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
            Application.ExitThread();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Usuario vnt0 = new Menu_Usuario();
            vnt0.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Paciente vnt1 = new Menu_Paciente();
            vnt1.Show();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Establecimiento vnt3 = new Menu_Establecimiento();
            vnt3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Consolidados vnt4 = new Menu_Consolidados ();
            vnt4.Show();
        }
    }
}
