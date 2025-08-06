//Cesar Estrada Elias 0901-22-10153
//se cambio de categoriaDAO.cs a cineDAO.cs
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
    public class CineDAO
    {
        private static readonly string SQL_SELECT = @"
            SELECT ID_Cine, Nombre, ID_plaza, Cantidad_de_Salas 
            FROM Cine";

        private static readonly string SQL_INSERT = @"
            INSERT INTO Cine (ID_Cine, Nombre, ID_plaza, Cantidad_de_Salas) 
            VALUES (@ID_Cine, @Nombre, @ID_plaza, @Cantidad_de_Salas)";
        //va a traerlo desde la tabla 
        private static readonly string SQL_UPDATE = @"
            UPDATE Cine SET 
                Nombre = @Nombre, 
                ID_plaza = @ID_plaza,
                Cantidad_de_Salas = @Cantidad_de_Salas
            WHERE ID_Cine = @ID_Cine";

        private static readonly string SQL_DELETE = "DELETE FROM Cine WHERE ID_Cine = @ID_Cine";

        private static readonly string SQL_QUERY = @"
            SELECT ID_Cine, Nombre, ID_plaza, Cantidad_de_Salas 
            FROM Cine 
            WHERE ID_Cine = @ID_Cine";

        public List<Cine> ObtenerCine()
        {
            List<Cine> cines = new List<Cine>();
            using (var conn = Conexion.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(SQL_SELECT, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cine cine = new Cine
                        {
                            ID_Cine = reader.GetInt32("ID_Cine"),
                            Nombre = reader.GetString("Nombre"),
                            ID_plaza = reader.GetInt32("ID_plaza"),
                            Cantidad_de_Salas = reader.GetInt32("Cantidad_de_Salas")
                        };
                        cines.Add(cine);
                    }
                }
            }
            return cines;
        }

        public int InsertarCine(Cine cine)
        {
            int filasAfectadas = 0;
            using (var conn = Conexion.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(SQL_INSERT, conn);
                cmd.Parameters.AddWithValue("@ID_Cine", cine.ID_Cine);
                cmd.Parameters.AddWithValue("@Nombre", cine.Nombre);
                cmd.Parameters.AddWithValue("@ID_plaza", cine.ID_plaza);
                cmd.Parameters.AddWithValue("@Cantidad_de_Salas", cine.Cantidad_de_Salas);
                filasAfectadas = cmd.ExecuteNonQuery();
            }
            return filasAfectadas;
        }

        public int ActualizarCine(Cine cine)
        {
            int filasAfectadas = 0;
            using (var conn = Conexion.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(SQL_UPDATE, conn);
                cmd.Parameters.AddWithValue("@Nombre", cine.Nombre);
                cmd.Parameters.AddWithValue("@ID_plaza", cine.ID_plaza);
                cmd.Parameters.AddWithValue("@Cantidad_de_Salas", cine.Cantidad_de_Salas);
                cmd.Parameters.AddWithValue("@ID_Cine", cine.ID_Cine);
                filasAfectadas = cmd.ExecuteNonQuery();
            }
            return filasAfectadas;
        }
        public bool TieneSalasAsociadas(int idCine)
        {
            using (var conn = Conexion.ObtenerConexion())
            {
                string sql = "SELECT COUNT(*) FROM SALA_DE_CINE WHERE ID_Cine = @ID_Cine";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID_Cine", idCine);
                int cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                return cantidad > 0;
            }
        }

        public int BorrarCine(Cine cine)
        {
            int filasAfectadas = 0;

            using (var conn = Conexion.ObtenerConexion())
            {
                // Validar si hay salas asociadas antes de eliminar
                if (TieneSalasAsociadas(cine.ID_Cine))
                {
                    throw new InvalidOperationException("No se puede eliminar el cine porque tiene salas asociadas.");
                }

                MySqlCommand cmd = new MySqlCommand(SQL_DELETE, conn);
                cmd.Parameters.AddWithValue("@ID_Cine", cine.ID_Cine);
                filasAfectadas = cmd.ExecuteNonQuery();
            }

            return filasAfectadas;
        }

        //public int BorrarCine(Cine cine)
        //{
        //    int filasAfectadas = 0;
        //    using (var conn = Conexion.ObtenerConexion())
        //    {
        //        MySqlCommand cmd = new MySqlCommand(SQL_DELETE, conn);
        //        cmd.Parameters.AddWithValue("@ID_Cine", cine.ID_Cine);
        //        filasAfectadas = cmd.ExecuteNonQuery();
        //    }
        //    return filasAfectadas;
        //}

        public Cine Query(int idCine)
        {
            Cine cine = null;
            using (var conn = Conexion.ObtenerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(SQL_QUERY, conn);
                cmd.Parameters.AddWithValue("@ID_Cine", idCine);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cine = new Cine
                        {
                            ID_Cine = reader.GetInt32("ID_Cine"),
                            Nombre = reader.GetString("Nombre"),
                            ID_plaza = reader.GetInt32("ID_plaza"),
                            Cantidad_de_Salas = reader.GetInt32("Cantidad_de_Salas")
                        };
                    }
                }
            }
            return cine;
        }

    }
}