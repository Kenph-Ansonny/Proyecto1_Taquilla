//Cesar Estrada Elias 0901-22-10153
//DAO para cargar catálogos de ComboBox
using MySql.Data.MySqlClient;
using Proyecto_Taquilla.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taquilla.Controlador
{
    public class CatalogoDAO
    {
        private static string connectionString = "server=localhost; database=Taquilla; user=root; password=cesar123";

        // Obtener Idiomas
        public static List<Idioma> ObtenerIdiomas()
        {
            List<Idioma> lista = new List<Idioma>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT ID_Idioma, Doblada, Subtitulos FROM Idioma";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Idioma idioma = new Idioma
                        {
                            ID_Idioma = reader.GetInt32("ID_Idioma"),
                            Doblada = reader.GetBoolean("Doblada"),
                            Subtitulos = reader.GetBoolean("Subtitulos")
                        };
                        lista.Add(idioma);
                    }
                }
            }
            return lista;
        }

        // Obtener Proyecciones
        public static List<TipoProyeccion> ObtenerProyecciones()
        {
            List<TipoProyeccion> lista = new List<TipoProyeccion>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT ID_Proyeccion, Tipo_de_proyeccion FROM Proyeccion";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TipoProyeccion proyeccion = new TipoProyeccion
                        {
                            ID_Proyeccion = reader.GetInt32("ID_Proyeccion"),
                            Tipo_de_proyeccion = reader.GetString("Tipo_de_proyeccion")
                        };
                        lista.Add(proyeccion);
                    }
                }
            }
            return lista;
        }

        // Obtener Películas
        public static List<Peliculacbx> ObtenerPeliculas()
        {
            List<Peliculacbx> lista = new List<Peliculacbx>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT id_pelicula, nombre_pelicula FROM Pelicula";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())//reviasr
                {
                    while (reader.Read())
                    {
                        Peliculacbx pelicula = new Peliculacbx
                        {
                            ID_Pelicula = reader.GetInt32("id_pelicula"),
                            Nombre = reader.GetString("nombre_pelicula")
                        };
                        lista.Add(pelicula);
                    }
                }
            }
            return lista;
        }

        // Obtener Salas de Cine
        public static List<SalaCine> ObtenerSalas()
        {
            List<SalaCine> lista = new List<SalaCine>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT ID_SALA_DE_CINE, No_Sala FROM SALA_DE_CINE";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SalaCine sala = new SalaCine
                        {
                            ID_SALA_DE_CINE = reader.GetInt32("ID_SALA_DE_CINE"),
                            No_Sala = reader.GetInt32("No_Sala")
                        };
                        lista.Add(sala);
                    }
                }
            }
            return lista;
        }
    }
}
