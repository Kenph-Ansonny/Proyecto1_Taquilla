//Cesar Armando estrada elias 0901-22-10153
//clase Funcion.cs 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taquilla.Modelo
{
    public class Funcion
    {
        // Propiedades principales (mapeo directo con la tabla Funcion)
        public int ID_Funcion { get; set; }
        public string Horario { get; set; }
        public DateTime Fecha { get; set; }
        public int ID_Pelicula { get; set; }
        public int Cantidad_Boletos { get; set; }
        public int ID_Sala { get; set; }
        public int ID_Idioma { get; set; }

        // Propiedades opcionales (para mostrar descripciones en la UI)
        public string Nombre_Pelicula { get; set; }
        public int No_Sala { get; set; }
        public string Descripcion_Idioma { get; set; } // Ej: "Doblada: Sí / Subtítulos: No"

        // Constructor vacío
        public Funcion() { }

        // Constructor completo
        public Funcion(int idFuncion, string horario, DateTime fecha, int idPelicula, int cantidadBoletos, int idSala, int idIdioma)
        {
            ID_Funcion = idFuncion;
            Horario = horario;
            Fecha = fecha;
            ID_Pelicula = idPelicula;
            Cantidad_Boletos = cantidadBoletos;
            ID_Sala = idSala;
            ID_Idioma = idIdioma;
        }
    }
}