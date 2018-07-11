using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Proyecto_isss_seguro.Clases
{
    class Muestra
    {
        public int idmuestra;
        public int idtipomuestra;
        public int idpaciente;
        public String fecha;
        public String observacionMuestra;
        public int idestablecimientorefe;
        public int idestablecimientoculti;

        public Muestra() { }
        public Muestra(int idmuestra, int idtipomuestra, int idpaciente, String fecha, String observacionMuestra, int idestablecimientorefe, int idestablecimientoculti)
        {
            this.idmuestra = idmuestra;
            this.idtipomuestra = idtipomuestra;
            this.idpaciente = idpaciente;
            this.fecha = fecha;
            this.observacionMuestra = observacionMuestra;
            this.idestablecimientorefe = idestablecimientorefe;
            this.idestablecimientoculti = idestablecimientoculti;
        }

        public Muestra( int idtipomuestra, int idpaciente, String fecha, String observacionMuestra, int idestablecimientorefe, int idestablecimientoculti)
        {
          
            this.idtipomuestra = idtipomuestra;
            this.idpaciente = idpaciente;
            this.fecha = fecha;
            this.observacionMuestra = observacionMuestra;
            this.idestablecimientorefe = idestablecimientorefe;
            this.idestablecimientoculti = idestablecimientoculti;
        }


        public static void listarMuestras(MySqlConnection conexion,String idPaciente,DataGridView dgv)
        {
            DataTable datat = new DataTable();

            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format("select IDMUESTRA, IDTIPODEMUESTRA, IDPACIENTE, OBSERVACIONMUESTRA, IDESTABLECIMIENTOREFE, IDESTABLECIMEINTOCULTI from muestra where IDPACIENTE='" + idPaciente + "'"), conexion);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comando);
                dataAdapter.Fill(datat);
                dgv.DataSource = datat;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }

        }


        public static void insertarMuestra(MySqlConnection conexion,Muestra mu)
        {
            Console.WriteLine("valor del tipo de muestra: "+mu.idtipomuestra);
            String query = "INSERT INTO muestra(IDTIPODEMUESTRA, IDPACIENTE, FECHA, OBSERVACIONMUESTRA, IDESTABLECIMIENTOREFE, IDESTABLECIMEINTOCULTI) VALUES ('"+mu.idtipomuestra+"','"+mu.idpaciente+"','"+mu.fecha+"','"+mu.observacionMuestra+"','"+mu.idestablecimientorefe+"','"+mu.idestablecimientoculti+"')";
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
