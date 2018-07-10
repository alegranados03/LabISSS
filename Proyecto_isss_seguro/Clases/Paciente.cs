using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace Proyecto_isss_seguro.Clases
{
    class Paciente
    {  //atributos de la clase
        int idPaciente { get; set; }
        String noafiliacion { get; set; }
        String nombre { get; set; }
        String apellido { get; set; }
        String direccion { get; set; }
        String grupoSanguineo { get; set; }
        String factorRH { get; set; }
        String genero { get; set; }
        String vih { get; set; }
        int edad { get; set; }
        String telefono { get; set; }

       


        //constructor vacío para iniciar un nuevo usuario sin asignarle valores a sus atributos
        public Paciente() { }

        //constructor con parámetros para iniciar un nuevo usuario asignandole valores a sus atributos
        public Paciente( int id,String noaf, String nomb, String apell, String dir, String gpoSanguineo, String factor, String genero, String vih, int edad, String tel)

        {

            this.idPaciente = id;
            this.noafiliacion = noaf;
            this.nombre = nomb;
            this.apellido = apell;
            this.direccion = dir;
            this.grupoSanguineo = gpoSanguineo;
            this.factorRH = factor;
            this.genero = genero;
            this.vih = vih;
            this.edad = edad;
            this.telefono = tel;

        }
        //constructor sin id
        public Paciente( String noaf, String nomb, String apell, String dir, String gpoSanguineo, String factor, String genero, String vih, int edad, String tel)

        {

            this.noafiliacion = noaf;
            this.nombre = nomb;
            this.apellido = apell;
            this.direccion = dir;
            this.grupoSanguineo = gpoSanguineo;
            this.factorRH = factor;
            this.genero = genero;
            this.vih = vih;
            this.edad = edad;
            this.telefono = tel;

        }



        public static void listarPacientes(MySqlConnection conexion,DataGridView dgv ) {
            DataTable datat = new DataTable();

            try {
                MySqlCommand comando = new MySqlCommand(string.Format(("select * from paciente")), conexion);
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comando);
                dataAdapter.Fill(datat);
                dgv.DataSource = datat;
            } catch(MySqlException ex)
            {
                throw ex;
            }

        }



        public static void insertarPaciente(MySqlConnection conexion, Paciente paciente)
        {
             String query= "INSERT INTO paciente(NOAFILIACION, NOMBRE, APELLIDO, DIRECCION, GRUPOSANGUINEO, FACTORRH, GENERO, VIH, EDAD, TELEFONOPACIENTE) VALUES('"+paciente.noafiliacion+ "','" + paciente.nombre + "','" + paciente.apellido + "','" + paciente.direccion + "','" + paciente.grupoSanguineo+ "','" + paciente.factorRH + "','" + paciente.genero + "','" + paciente.vih + "','" + paciente.edad + "', '" + paciente.telefono + "')";
            try
            {
                MySqlCommand comando = new MySqlCommand(query, conexion);
                Int32 lector = (Int32)comando.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            { throw ex; }



        }
<<<<<<< HEAD
        public static void actualizarPaciente(MySqlConnection conexion, Paciente paciente)
        {
            String query = "UPDATE paciente set NOAFILIACION = '" + paciente.noafiliacion + "', NOMBRE = '" + paciente.nombre + "', APELLIDO = '" + paciente.apellido + "', DIRECCION = '" + paciente.direccion + "', GRUPOSANGUINEO = '" + paciente.grupoSanguineo + "', FACTORRH = '" + paciente.factorRH + "', GENERO = '" + paciente.genero + "', VIH = '" + paciente.vih + "', EDAD = '" + paciente.edad + "', TELEFONOPACIENTE = '" + paciente.telefono + "' where idpaciente = '" + paciente.idPaciente + "'";
            try
            {
                MySqlCommand comando = new MySqlCommand(query, conexion);
                Int32 lector = (Int32)comando.ExecuteNonQuery();
=======



        public static MySqlDataReader cargarPaciente(MySqlConnection conexion, String id)
        {
            String query = "select * from paciente where idPaciente='"+id+"'";
            try
            {
                MySqlCommand comando = new MySqlCommand(query, conexion);
                MySqlDataReader datos = null; comando.ExecuteReader();

                return datos;
>>>>>>> 36567d1e3b384d95f97644027fd0ca921093b614

            }
            catch (MySqlException ex)
            { throw ex; }
<<<<<<< HEAD
=======



>>>>>>> 36567d1e3b384d95f97644027fd0ca921093b614
        }
    }

}
