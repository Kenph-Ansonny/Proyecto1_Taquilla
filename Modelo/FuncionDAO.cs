//cesar armando estrada elias 0901-22-10153
//se creo la clase FuncionDAO.cs
//Cesar Estrada Elias 0901-22-10153
//Se creó FuncionDAO.cs basado en la estructura de CineDAO.cs

using MySql.Data.MySqlClient;
using Proyecto_Taquilla.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taquilla.Controlador
{
    public class FuncionDAO
    {
        private static string connectionString = "server=localhost; database=Taquilla; user=root; password=cesar123";

        // Obtener todas las funciones
        public static List<Funcion> ObtenerFunciones()
        {
            List<Funcion> lista = new List<Funcion>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Funcion";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Funcion funcion = new Funcion
                    (
                        reader.GetInt32("ID_Funcion"),
                        reader.GetString("Horario"),
                        reader.GetDateTime("Fecha"),
                        reader.GetInt32("ID_Pelicula"),
                        reader.GetInt32("Cantidad_Boletos"),
                        reader.GetInt32("ID_SALA_DE_CINE"),
                        reader.GetInt32("ID_Idioma"),
                        reader.GetInt32("ID_Proyeccion")
                    );
                    lista.Add(funcion);
                }
            }
            return lista;
        }

        // Insertar una nueva función
        public static void InsertarFuncion(Funcion funcion)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO Funcion 
                (ID_Funcion, Horario, Fecha, ID_Pelicula, Cantidad_Boletos, ID_SALA_DE_CINE, ID_Idioma, ID_Proyeccion) 
                VALUES (@id, @horario, @fecha, @id_pelicula, @cantidad, @id_sala, @id_idioma, @id_proyeccion)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", funcion.ID_Funcion);
                    cmd.Parameters.AddWithValue("@horario", funcion.Horario);
                    cmd.Parameters.AddWithValue("@fecha", funcion.Fecha);
                    cmd.Parameters.AddWithValue("@id_pelicula", funcion.ID_Pelicula);
                    cmd.Parameters.AddWithValue("@cantidad", funcion.Cantidad_Boletos);
                    cmd.Parameters.AddWithValue("@id_sala", funcion.ID_SALA_DE_CINE);
                    cmd.Parameters.AddWithValue("@id_idioma", funcion.ID_Idioma);
                    cmd.Parameters.AddWithValue("@id_proyeccion", funcion.ID_Proyeccion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Actualizar una función existente
        public static void ActualizarFuncion(Funcion funcion)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"UPDATE Funcion SET 
                    Horario = @horario, 
                    Fecha = @fecha, 
                    ID_Pelicula = @id_pelicula, 
                    Cantidad_Boletos = @cantidad, 
                    ID_SALA_DE_CINE = @id_sala, 
                    ID_Idioma = @id_idioma, 
                    ID_Proyeccion = @id_proyeccion 
                WHERE ID_Funcion = @id";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", funcion.ID_Funcion);
                    cmd.Parameters.AddWithValue("@horario", funcion.Horario);
                    cmd.Parameters.AddWithValue("@fecha", funcion.Fecha);
                    cmd.Parameters.AddWithValue("@id_pelicula", funcion.ID_Pelicula);
                    cmd.Parameters.AddWithValue("@cantidad", funcion.Cantidad_Boletos);
                    cmd.Parameters.AddWithValue("@id_sala", funcion.ID_SALA_DE_CINE);
                    cmd.Parameters.AddWithValue("@id_idioma", funcion.ID_Idioma);
                    cmd.Parameters.AddWithValue("@id_proyeccion", funcion.ID_Proyeccion);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Eliminar una función por ID
        public static void EliminarFuncion(int idFuncion)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Funcion WHERE ID_Funcion = @idFuncion";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@idFuncion", idFuncion);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
