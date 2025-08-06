//cesar armando estrada elias 0901-22-10153
//se creo la clase FuncionDAO.cs
//Cesar Estrada Elias 0901-22-10153
//Se creó FuncionDAO.cs basado en la estructura de CineDAO.cs

using MySql.Data.MySqlClient;
using Proyecto_Taquilla.Controlador;
using Proyecto_Taquilla.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taquilla.Modelo
{
    public class FuncionDAO
    {
        // SELECT con unión para traer capacidad desde SALA_DE_CINE
        private static readonly string SQL_SELECT = @"
            SELECT f.ID_Funcion, f.Horario, f.Fecha, f.ID_Pelicula, 
                   sc.Capacidad_de_Asientos AS Cantidad_Boletos, 
                   f.ID_Sala, f.ID_Idioma,
                   p.Nombre AS Nombre,
                   sc.No_Sala as No_Sala,
                   CONCAT('Doblada: ', IF(i.Doblada = 1, 'Sí', 'No'), ' / Subtítulos: ', IF(i.Subtitulos = 1, 'Sí', 'No')) AS Descripcion_Idioma
            FROM Funcion f
            INNER JOIN Pelicula p ON f.ID_Pelicula = p.ID_Pelicula
            INNER JOIN Sala s ON f.ID_Sala = s.ID_Sala
            INNER JOIN SALA_DE_CINE sc ON s.ID_Sala = sc.ID_Sala
            INNER JOIN Idioma i ON f.ID_Idioma = i.ID_Idioma";

        private static readonly string SQL_INSERT = @"
            INSERT INTO Funcion (ID_Funcion, Horario, Fecha, ID_Pelicula, ID_Sala, ID_Idioma)
            VALUES (@id_funcion, @horario, @fecha, @id_pelicula, @id_sala, @id_idioma)";

        private static readonly string SQL_UPDATE = @"
            UPDATE Funcion 
            SET Horario = @horario, Fecha = @fecha, ID_Pelicula = @id_pelicula, 
                ID_Sala = @id_sala, ID_Idioma = @id_idioma
            WHERE ID_Funcion = @id_funcion";

        private static readonly string SQL_DELETE = @"DELETE FROM Funcion WHERE ID_Funcion = @id_funcion";

        private static readonly string SQL_UPDATE_CAPACIDAD_SALA = @"UPDATE SALA_DE_CINE SET Capacidad_de_Asientos = @capacidad WHERE ID_Sala = @id_sala";

        // Obtener todas las funciones
        public static List<Funcion> ObtenerFunciones()
        {
            List<Funcion> lista = new List<Funcion>();

            using (var conn = Conexion.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Funcion f = new Funcion
                        {
                            ID_Funcion = reader.GetInt32("ID_Funcion"),
                            Horario = reader.GetString("Horario"),
                            Fecha = reader.GetDateTime("Fecha"),
                            ID_Pelicula = reader.GetInt32("ID_Pelicula"),
                            Cantidad_Boletos = reader.GetInt32("Cantidad_Boletos"), // viene de SALA_DE_CINE
                            ID_Sala = reader.GetInt32("ID_Sala"),
                            ID_Idioma = reader.GetInt32("ID_Idioma"),
                            Nombre_Pelicula = reader.GetString("Nombre"),
                            No_Sala = reader.GetInt32("No_Sala"),
                            Descripcion_Idioma = reader.GetString("Descripcion_Idioma")
                        };
                        lista.Add(f);
                    }
                }
            }

            return lista;
        }

        // Insertar nueva función
        public static void InsertarFuncion(Funcion funcion)
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT, conn);
                cmd.Parameters.AddWithValue("@id_funcion", funcion.ID_Funcion);
                cmd.Parameters.AddWithValue("@horario", funcion.Horario);
                cmd.Parameters.AddWithValue("@fecha", funcion.Fecha);
                cmd.Parameters.AddWithValue("@id_pelicula", funcion.ID_Pelicula);
                cmd.Parameters.AddWithValue("@id_sala", funcion.ID_Sala);
                cmd.Parameters.AddWithValue("@id_idioma", funcion.ID_Idioma);
                cmd.ExecuteNonQuery();
            }
        }

        // Actualizar datos de la función
        public static void ActualizarFuncion(Funcion funcion)
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE, conn);
                cmd.Parameters.AddWithValue("@horario", funcion.Horario);
                cmd.Parameters.AddWithValue("@fecha", funcion.Fecha);
                cmd.Parameters.AddWithValue("@id_pelicula", funcion.ID_Pelicula);
                cmd.Parameters.AddWithValue("@id_sala", funcion.ID_Sala);
                cmd.Parameters.AddWithValue("@id_idioma", funcion.ID_Idioma);
                cmd.Parameters.AddWithValue("@id_funcion", funcion.ID_Funcion);

                int filas = cmd.ExecuteNonQuery();
                if (filas == 0)
                {
                    MessageBox.Show("No se encontró ninguna función con ese ID.");
                }
            }
        }

        // Eliminar función
        public static void EliminarFuncion(int id_funcion)
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(SQL_DELETE, conn);
                cmd.Parameters.AddWithValue("@id_funcion", id_funcion);
                cmd.ExecuteNonQuery();
            }
        }

        // Actualizar la capacidad de la sala (Cantidad_Boletos)
        public static void ActualizarCapacidadSala(int idSala, int nuevaCapacidad)
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE_CAPACIDAD_SALA, conn);
                cmd.Parameters.AddWithValue("@capacidad", nuevaCapacidad);
                cmd.Parameters.AddWithValue("@id_sala", idSala);
                cmd.ExecuteNonQuery();
            }
        }
    }
}