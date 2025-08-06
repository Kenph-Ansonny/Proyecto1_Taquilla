//antes era categoria.cs se cambio a cine
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Taquilla.Modelo
{
    public class Cine
    {
        public int ID_Cine { get; set; }
        public string Nombre { get; set; }
        public int ID_plaza { get; set; }
        public int Cantidad_de_Salas { get; set; }
        public Cine(int id_cine, string nombre, int id_plaza, int cantidad_de_Salas)
        {
            ID_Cine = id_cine;
            this.Nombre = nombre;
            ID_plaza = id_plaza;
            Cantidad_de_Salas = cantidad_de_Salas;
        }
        public Cine() { }
    }
}