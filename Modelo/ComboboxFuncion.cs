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
        //Sirve para el dsiplay de la vista Funcion

        public string Descripcion
        {
            get
            {
                string texto = "";
                if (Doblada) texto += "Doblada/ESP";//doblada al español
                if (Subtitulos) texto += (texto != "" ? " y " : "") + "Subtitulada/Original";
                return texto == "" ? "Original" : texto;//Idioma original
            }
        }
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
