﻿//Cesar Armando estrada elias 0901-22-10153
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
        public int ID_Funcion { get; set; }
        public string Horario { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad_Boletos { get; set; }

        // IDs
        public int ID_Pelicula { get; set; }
        public int ID_SALA_DE_CINE { get; set; }
        public int ID_Idioma { get; set; }
        public int ID_Proyeccion { get; set; }

        // Propiedades descriptivas
        public string Nombre_Pelicula { get; set; }
        public int No_Sala { get; set; }
        public string Descripcion_Idioma { get; set; } // "Doblada: Sí / Subtítulos: No"
        public string Tipo_Proyeccion { get; set; }    // "2D", "3D", etc.

        // Constructor con parámetros
        public Funcion(int id_funcion, string horario, DateTime fecha, int id_pelicula, int cantidad_boletos,
                       int id_sala_de_cine, int id_idioma, int id_proyeccion)
        {
            ID_Funcion = id_funcion;
            Horario = horario;
            Fecha = fecha;
            ID_Pelicula = id_pelicula;
            Cantidad_Boletos = cantidad_boletos;
            ID_SALA_DE_CINE = id_sala_de_cine;
            ID_Idioma = id_idioma;
            ID_Proyeccion = id_proyeccion;
        }

        // Constructor vacío
        public Funcion() { }
    }
}