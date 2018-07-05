using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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



    }


  

    
}
