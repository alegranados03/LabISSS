using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Proyecto_isss_seguro.Clases
{
    class TipoMuestra
    {
        public int idTipoMuestra { get; set; }
        public String nombreTipoMuestra { get; set; }


        public TipoMuestra() {  }
        public TipoMuestra(int idTipoMuestra,String nombreTipoMuestra) {
            this.idTipoMuestra = idTipoMuestra;
            this.nombreTipoMuestra = nombreTipoMuestra;
        }

        public static List<TipoMuestra> cargarCbTipoMuestra(MySqlConnection conexion)

        {

            String query = "Select * from tipoMuestra";

            List<TipoMuestra> le = new List<TipoMuestra>();
            MySqlCommand comando = new MySqlCommand(query, conexion);
            MySqlDataReader rd = comando.ExecuteReader();

            while (rd.Read())
            {
                TipoMuestra tm = new TipoMuestra();
                tm.idTipoMuestra = rd.GetInt32(0);
                tm.nombreTipoMuestra = rd.GetString(1);
                le.Add(tm);
            }
            return le;
        }
    }
}
