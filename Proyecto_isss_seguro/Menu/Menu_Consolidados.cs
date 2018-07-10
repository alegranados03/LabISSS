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
    public partial class Menu_Consolidados : Form
    {
        public Menu_Consolidados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CC_BK_Muestras vnt0 = new CC_BK_Muestras();
            vnt0.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CC_BK_General vnt1 = new CC_BK_General();
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
