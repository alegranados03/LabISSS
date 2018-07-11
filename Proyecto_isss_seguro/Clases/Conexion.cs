using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_isss_seguro.Clases
{
    class Conexion
    {
        //atributos de la clase
        public MySqlConnection conexion;
  
        //constructor vacío para iniciar una nueva conexión
        public Conexion()
        {
            conexion = new MySqlConnection("server=localhost; port=3306; database=isss2018; Uid=root; pwd=; SslMode=none");
        }
 
        //método para conectar a la base de datos, retorna true si la conexión es exitosa
        public bool conectar()
        {

            try { conexion.Open();
                
                return true;

            } catch (MySqlException ex) {
                return false;
                throw ex;

            }




        }
        //método para desconectar de la base de datos, retorna true si el procedimiento es exitoso
        public bool desconectar()
        {
            try { conexion.Close();
                return true;
            }


            catch(MySqlException ex) {
                return false;
                    throw ex;
            }


        }

    }
}
