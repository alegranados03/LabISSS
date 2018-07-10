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
    }
}
