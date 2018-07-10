using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Proyecto_isss_seguro.Clases
{
    class User
    {    //atributos de la clase
        public int idusuario { get; set; }
        public String nombres { get; set; }
        public String apellidos { get; set; }
        public String usuario { get; set; }
        public String contrasena { get; set; }
        public String tipoUsuario { get; set; }

        //constructor vacío para iniciar un nuevo usuario sin asignarle valores a sus atributos
        public User() { }

        //constructor con parámetros para iniciar un nuevo usuario asignandole valores a sus atributos
        public User(int idus,String nombs, String apell, String username, String pass, String tipoUser ) {

            this.idusuario = idus;
            this.nombres = nombs;
            this.apellidos = apell;
            this.usuario = username;
            this.contrasena = pass;
            this.tipoUsuario = tipoUser;
        }
        //constructor sin id
        public User( String nombs, String apell, String username, String pass, String tipoUser)
        {
            this.nombres = nombs;
            this.apellidos = apell;
            this.usuario = username;
            this.contrasena = pass;
            this.tipoUsuario = tipoUser;
        }



        public static bool validarSesion(MySqlConnection conexion,String username,String password)
        {  String query= "select * from usuario where usuario='"+username+"' and contraseña='"+password+"'";
            try {
                MySqlCommand comando = new MySqlCommand(query, conexion);
                MySqlDataReader lector = comando.ExecuteReader();
                
                if (lector.Read())
                {
                    return true;
                }else {
                    return false; }

            } catch(MySqlException ex){
                throw ex;
            }
        }


        public static String obtenerTipoU(MySqlConnection conexion, String username, String password)
        {
            String query = "select tipoUsuario from usuario where usuario='" + username + "' and contraseña='" + password + "'";
            String resultado="";
            try
            {
                MySqlCommand comando = new MySqlCommand(query, conexion);
                MySqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    resultado = lector.GetString(0);
                }
      
                return resultado;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }



        public static void insertarUsuario(MySqlConnection conexion, User us)
        {
            
            String query = "insert into usuario (NOMBRES,APELLIDOS,USUARIO,CONTRASEÑA,TIPOUSUARIO) VALUES ('" + us.nombres + "','" + us.apellidos + "','" + us.usuario + "','" + us.contrasena+"','"+us.tipoUsuario+"')";
            try
            {
                MySqlCommand comando = new MySqlCommand(query, conexion);
                Int32 lector = (Int32)comando.ExecuteNonQuery();
                
            }
            catch(MySqlException ex)
            { throw ex; }



        }

        public static void listarUsuarios(MySqlConnection conexion, DataGridView dgv)
        {
            DataTable datat = new DataTable();

            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format(("SELECT IDUSUARIO, NOMBRES, APELLIDOS, USUARIO, TIPOUSUARIO FROM usuario")), conexion);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comando);
                dataAdapter.Fill(datat);
                dgv.DataSource = datat;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }




        }

        public static void actualizarUsuario(MySqlConnection conexion, User us)
        {
            String query = "update usuario set NOMBRES = '" + us.nombres + "', APELLIDOS = '" + us.apellidos + "', USUARIO = '" + us.usuario + "', TIPOUSUARIO = '"+us.tipoUsuario+"' where idusuario = '" + us.idusuario + "'";
            try
            {
                MySqlCommand comando = new MySqlCommand(query, conexion);
                Int32 lector = (Int32)comando.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            { throw ex; }
        }
        public static void EliminarUsuario(MySqlConnection conexion, String us)
        {
            String query = "delete from usuario where idusuario = '"+ us +"'";
            try
            {
                MySqlCommand comando = new MySqlCommand(query, conexion);
                Int32 lector = (Int32)comando.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            { throw ex; }
        }

    }


  

    
}
