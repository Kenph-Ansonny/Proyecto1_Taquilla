//Cesar Astrada Elias 0901-22-10153
//Se utilizara para llenar los combobox de la clase Funcion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taquilla.Modelo
{
    public class Idioma
    {
        public int ID_Idioma { get; set; }
        public bool Doblada { get; set; }
        public bool Subtitulos { get; set; }

        public string Descripcion => $"Doblada: {(Doblada ? "Sí" : "No")} / Subtítulos: {(Subtitulos ? "Sí" : "No")}";
    }

    public class TipoProyeccion
    {
        public int ID_Proyeccion { get; set; }
        public string Tipo_de_proyeccion { get; set; }
    }

    public class Peliculacbx
    {
        public int ID_Pelicula { get; set; }
        public string Nombre { get; set; }
    }

    public class SalaCine
    {
        public int ID_SALA_DE_CINE { get; set; }
        public int No_Sala { get; set; }
    }
}
