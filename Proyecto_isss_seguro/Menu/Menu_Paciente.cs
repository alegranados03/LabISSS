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
    public partial class Menu_Paciente : Form
    {
        public Menu_Paciente()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Manager vnt2 = new Menu_Manager();
            vnt2.Show();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ingresar_Paciente vnt0 = new Ingresar_Paciente();
            vnt0.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ver_Paciente vnt1 = new Ver_Paciente();
            vnt1.Show();
        }
    }
}
