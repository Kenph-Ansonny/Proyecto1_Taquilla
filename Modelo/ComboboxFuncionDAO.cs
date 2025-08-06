//Cesar Estrada Elias 0901-22-10153
//DAO para cargar catálogos de ComboBox
using MySql.Data.MySqlClient;
using Proyecto_Taquilla.Controlador;
using Proyecto_Taquilla.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taquilla.Controlador
{
    public class ComboboxFuncionDAO
    {
        // Obtener lista de idiomas
        public static List<Idioma> ObtenerIdiomas()
        {
            List<Idioma> lista = new List<Idioma>();

            using (var conn = Conexion.ObtenerConexion())
            {
                string sql = "SELECT ID_Idioma, Doblada, Subtitulos FROM Idioma";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

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

        // Obtener lista de películas
        public static List<Peliculacbx> ObtenerPeliculas()
        {
            List<Peliculacbx> lista = new List<Peliculacbx>();

            using (var conn = Conexion.ObtenerConexion())
            {
                string sql = "SELECT ID_Pelicula, Nombre FROM Pelicula";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Peliculacbx pelicula = new Peliculacbx
                        {
                            ID_Pelicula = reader.GetInt32("ID_Pelicula"),
                            Nombre = reader.GetString("Nombre")
                        };
                        lista.Add(pelicula);
                    }
                }
            }

            return lista;
        }

        // Obtener lista de salas
        public static List<SalaCine> ObtenerSalas()
        {
            List<SalaCine> lista = new List<SalaCine>();

            using (var conn = Conexion.ObtenerConexion())
            {
                string sql = "SELECT ID_Sala, No_Sala FROM SALA_DE_CINE";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SalaCine sala = new SalaCine
                        {
                            ID_SALA_DE_CINE = reader.GetInt32("ID_Sala"),
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