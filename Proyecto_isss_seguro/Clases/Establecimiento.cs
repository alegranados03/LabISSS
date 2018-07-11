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
    class Establecimiento
    {
      public  int idEstablecimiento { get; set; }
        int idEntidad { get; set; }
        int idRegion { get; set; }
      public  String nombreEstablecimiento { get; set; }
        String tipoEstablecimiento { get; set; }
        String direccionEstablecimiento { get; set; }
        String telefonoEstablecimiento { get; set; }

        public Establecimiento() { }
        public Establecimiento(int id,int ident,int idreg,String nombre, String tipo,String dir,String tel) {

            this.idEstablecimiento = id;
            this.idEntidad = ident;
            this.idRegion = idreg;
            this.nombreEstablecimiento = nombre;
            this.tipoEstablecimiento = tipo;
            this.direccionEstablecimiento =dir;
            this.telefonoEstablecimiento = tel;
        }
        public Establecimiento(int ident, int idreg, String nombre, String tipo, String dir, String tel) {
            this.idEntidad = ident;
            this.idRegion = idreg;
            this.nombreEstablecimiento = nombre;
            this.tipoEstablecimiento = tipo;
            this.direccionEstablecimiento = dir;
            this.telefonoEstablecimiento = tel;
        }

        public static void listarEstablecimientosISSS(MySqlConnection conexion, DataGridView dgv)
        {
            DataTable datat = new DataTable();

            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format(("select * from establecimiento where identidad=1")), conexion);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comando);
                dataAdapter.Fill(datat);
                dgv.DataSource = datat;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }

        }

        public static void listarEstablecimientosMINSAL(MySqlConnection conexion, DataGridView dgv)
        {
            DataTable datat = new DataTable();

            try
            {
                MySqlCommand comando = new MySqlCommand(string.Format(("select * from establecimiento where identidad=2")), conexion);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comando);
                dataAdapter.Fill(datat);
                dgv.DataSource = datat;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }

        }


        public static void insertarEstablecimiento(MySqlConnection conexion, Establecimiento est)
        {
            String query = "INSERT INTO establecimiento(IDENTIDAD, IDREGION, NOMBREESTABLECIMIENTO, TIPOESTABLECIMIENTO, DIRECCIONESTABLECIMIENTO, TELEFONOESTABLECIMIENTO) VALUES ('"+ est.idEntidad + "','"+ est.idRegion + "','"+ est.nombreEstablecimiento + "','" + est.tipoEstablecimiento + "','"+ est.direccionEstablecimiento + "','" +est.telefonoEstablecimiento + "')";
            try
            {
                MySqlCommand comando = new MySqlCommand(query, conexion);
                Int32 lector = (Int32)comando.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            { throw ex; }
        }
        public static void actualizarEstablecimiento(MySqlConnection conexion, Establecimiento est)
        {
            String query = "UPDATE establecimiento set IDENTIDAD = '" + est.idEntidad + "', IDREGION = '" + est.idRegion + "', NOMBREESTABLECIMIENTO = '"+ est.nombreEstablecimiento + "', TIPOESTABLECIMIENTO = '" + est.tipoEstablecimiento + "', DIRECCIONESTABLECIMIENTO = '"+ est.direccionEstablecimiento + "', TELEFONOESTABLECIMIENTO = '" +est.telefonoEstablecimiento + "' where IdEstablecimiento = '" + est.idEstablecimiento + "'";
            try
            {
                MySqlCommand comando = new MySqlCommand(query, conexion);
                Int32 lector = (Int32)comando.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            { throw ex; }
        }


        public static List<Establecimiento>cargarestablecimientosrefamot(MySqlConnection conexion)
        
        {
        
 String query = "Select IDESTABLECIMIENTO, NOMBREESTABLECIMIENTO from establecimiento where TIPOESTABLECIMIENTO='De Referencia' or TIPOESTABLECIMIENTO='Ambos' or TIPOESTABLECIMIENTO='Otros'";
                
            List<Establecimiento> le = new List<Establecimiento>();
            MySqlCommand comando = new MySqlCommand(query, conexion);
            MySqlDataReader rd = comando.ExecuteReader();

            while (rd.Read())
            {
                Establecimiento es = new Establecimiento();
                es.idEstablecimiento = rd.GetInt32(0);
                es.nombreEstablecimiento = rd.GetString(1);
                Console.WriteLine("ESTABLECIMIENTO"+es.nombreEstablecimiento);
                Console.WriteLine("SU ID"+es.idEstablecimiento);
                le.Add(es);
            }
            return le;
        }


        public static List<Establecimiento> cargarestablecimientoscultamot(MySqlConnection conexion)

        {

            String query = "Select IDESTABLECIMIENTO, NOMBREESTABLECIMIENTO from establecimiento where TIPOESTABLECIMIENTO='De Cultivo' or TIPOESTABLECIMIENTO='Ambos' or TIPOESTABLECIMIENTO='Otros'";

            List<Establecimiento> le = new List<Establecimiento>();
            MySqlCommand comando = new MySqlCommand(query, conexion);
            MySqlDataReader rd = comando.ExecuteReader();

            while (rd.Read())
            {
                Establecimiento es = new Establecimiento();
                es.idEstablecimiento = rd.GetInt32(0);
                es.nombreEstablecimiento = rd.GetString(1);
                Console.WriteLine("ESTABLECIMIENTO" + es.nombreEstablecimiento);
                Console.WriteLine("SU ID" + es.idEstablecimiento);
                le.Add(es);
            }
            return le;
        }
    }
}
