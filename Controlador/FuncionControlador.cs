// Cesar Estrada Elias 0901-22-10153
// Controlador para la clase Funcion con métodos por parámetros 

using Proyecto_Taquilla.Modelo;
using System.Collections.Generic;

namespace Proyecto_Taquilla.Controlador
{
    public class FuncionControlador
    {
        // Obtener todas las funciones
        public List<Funcion> ObtenerTodosFunciones()
        {
            return FuncionDAO.ObtenerFunciones();
        }

        // Insertar una nueva función con parámetros
        public void InsertarFuncion(Funcion funcion)
        {
            FuncionDAO.InsertarFuncion(funcion);
        }

        // Actualizar una función con parámetros
        public void ActualizarFuncion(Funcion funcion)
        {
            FuncionDAO.ActualizarFuncion(funcion);
        }

        // Eliminar una función por su ID
        public void EliminarFuncion(int id_funcion)
        {
            FuncionDAO.EliminarFuncion(id_funcion);
        }
    }
}
