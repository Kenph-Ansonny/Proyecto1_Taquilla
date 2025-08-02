//Librerias 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;



//Se utilizará para llamar la clase en otros archivos donde se necesite la conexion de la base de datos
namespace Proyecto_Taquilla.Controlador
{
    public class Conexion
    {   //Conecta la base de datos desde un localhost (con puerto 3306) de la base de datos "Taquilla" con el usuario "root" y su contraseña
        private static readonly string connectionString = "server=localhost;port=3306;database=Taquilla;user=root;password=cesar123;SslMode=none";

        //Manejo de errores y excepciones con un trycatch para evitar que el programa falle en caso de error
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {   //abre la conexion
                conn.Open();
                return conn;
            } //maneja una excepcion si la conexion falla
            catch (MySqlException ex)
            {
                Console.WriteLine("Conexión con la base de datos fallida: " + ex.Message);
                return null;
            }
        }

        //Se cierra la conexion con la base de datos
        public static void CerrarConexion(MySqlConnection conn)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}

