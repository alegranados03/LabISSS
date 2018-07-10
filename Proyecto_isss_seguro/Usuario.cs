using MySql.Data.MySqlClient;
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
    public partial class Usuario : Form
    {

        Clases.Conexion con = new Clases.Conexion();
        public Usuario()
        {
            InitializeComponent();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.conectar() == true)
                {
                    if (validar(con.conexion, txtU.Text, txtP.Text))
                    {
                        con.desconectar();
                        con.conectar();
                        String tipoUser = obtenerTipoUsuario(con.conexion, txtU.Text, txtP.Text);
                       if( tipoUser== "ADMIN")
                        {
                            this.Hide();
                            Menu_Manager vnt1 = new Menu_Manager();
                            vnt1.Show();

                        }
                        else if (tipoUser == "LOCAL") {
                         
                        } else {
                          
                        }
                    }
                    else {
                        MessageBox.Show("error en inicio de sesión, usuario o contraseña incorrecto"); }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error en conexion"+ex);
            }
            con.desconectar();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
                     
        }

        public bool validar(MySqlConnection conexion,String User, String Pass)
        {   
            return Clases.User.validarSesion(conexion, User, Pass);
        }


        public String obtenerTipoUsuario(MySqlConnection conexion, String User, String Pass)
        {
            return Clases.User.obtenerTipoU(conexion, User, Pass); ;
        }

        private void Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    if (con.conectar() == true)
                    {
                        if (validar(con.conexion, txtU.Text, txtP.Text))
                        {
                            con.desconectar();
                            con.conectar();
                            String tipoUser = obtenerTipoUsuario(con.conexion, txtU.Text, txtP.Text);
                            if (tipoUser == "ADMIN")
                            {
                                this.Hide();
                                Menu_Manager vnt1 = new Menu_Manager();
                                vnt1.Show();

                            }
                            else if (tipoUser == "LOCAL")
                            {

                            }
                            else
                            {

                            }
                        }
                        else
                        {
                            MessageBox.Show("error en inicio de sesión, usuario o contraseña incorrecto");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error en conexion" + ex);
                }
                con.desconectar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Application.ExitThread();
        }
    }
}