﻿using System;
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
    public partial class Ingreso_Prueba_GX : Form
    {
        public Ingreso_Prueba_GX()
        {
            InitializeComponent();
        }

        private void buttoncancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ingresar_Prueba_Registrada vnt0 = new Ingresar_Prueba_Registrada();
            vnt0.Show();
        }
    }
}
