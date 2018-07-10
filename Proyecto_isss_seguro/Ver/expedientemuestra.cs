using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_isss_seguro.Ver
{
    public partial class expedientemuestra : Form
    {
        public expedientemuestra()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ver.Expediente vnt0 = new Ver.Expediente();
            vnt0.Show();

        }
    }
}
