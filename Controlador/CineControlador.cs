//Cesar Astrada Elias 0901-22-10153
//Antes era CategoriaController.cs ahorda se cambio a CineController.cs
using Proyecto_Taquilla.Modelo;
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Taquilla.Controlador;
using System.Collections.Generic;

namespace Proyecto_Taquilla.Controlador
{
    public class CineController
    {
        // Obtener todos los cines
        public List<Cine> ObtenerTodosLosCines()
        {
            return new CineDAO().ObtenerCine();
        }

        // Insertar un nuevo cine
        public int InsertarCine(Cine cine)
        {
            return new CineDAO().InsertarCine(cine);
        }

        // Actualizar un cine existente
        public int ActualizarCine(int id_cine, string nombre, int id_plaza, int cantidad_salas)
        {
            Cine actualizado = new Cine(id_cine, nombre, id_plaza, cantidad_salas);
            return new CineDAO().ActualizarCine(actualizado);
        }

        // Eliminar un cine por ID
        public int EliminarCine(int idCine)
        {
            Cine cine = new Cine { ID_Cine = idCine };
            return new CineDAO().BorrarCine(cine);
        }

        // Consultar un cine por ID
        public Cine BuscarCinePorId(int idCine)
        {
            return new CineDAO().Query(idCine);
        }
    }
}