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
    public partial class CC_BK_General : Form
    {
        public CC_BK_General()
        {
            InitializeComponent();
        }

        private void buttoncancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Consolidados vnt0 = new Menu_Consolidados();
            vnt0.Show();
        }
    }
}
