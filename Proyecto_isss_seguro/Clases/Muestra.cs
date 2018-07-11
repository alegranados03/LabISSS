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
        int idmuestra;
        int idtipoprueba;
        int idpaciente;
        String fecha;
        String observacionMuestra;
        int idestablecimientorefe;
        int idestablecimientoculti;

        public Muestra() { }
        public Muestra(int idmuestra, int idtipoprueba, int idpaciente, String fecha, String observacionMuestra, int idestablecimientorefe, int idestablecimientoculti)
        {
            this.idmuestra = idmuestra;
            this.idtipoprueba = idtipoprueba;
            this.idpaciente = idpaciente;
            this.fecha = fecha;
            this.observacionMuestra = observacionMuestra;
            this.idestablecimientorefe = idestablecimientorefe;
            this.idestablecimientoculti = idestablecimientoculti;
        }

        public Muestra( int idtipoprueba, int idpaciente, String fecha, String observacionMuestra, int idestablecimientorefe, int idestablecimientoculti)
        {
          
            this.idtipoprueba = idtipoprueba;
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
                MySqlCommand comando = new MySqlCommand(string.Format("select * from muestra where IDPACIENTE='" + idPaciente + "'"), conexion);
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

        }
    }
}
