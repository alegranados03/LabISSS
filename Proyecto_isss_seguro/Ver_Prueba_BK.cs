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
    public partial class Ver_Prueba_BK : Form
    {
        public Ver_Prueba_BK()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ver_Prueba vnt0 = new Ver_Prueba();
            vnt0.Show();
        }
    }
}
