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
    public partial class Menu_Usuario : Form
    {
        public Menu_Usuario()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_Manager vnt0 = new Menu_Manager();
            vnt0.Show();
        }

        private void Menu_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agregar_Usuario vnt01 = new Agregar_Usuario();
            vnt01.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ver_Usuario vnt02 = new Ver_Usuario();
            vnt02.Show();
        }
    }
}
