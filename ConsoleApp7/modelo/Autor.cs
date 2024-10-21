using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.modelo
{
    // autor es una clase
    internal class Autor
    {
        // propiedades: (metodos)
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Genero { set; get; }

        public Autor(string nombre, string apellido, string genero)
        {
            Nombre = nombre;
            Apellido = apellido;
            Genero = genero;
        }

        public Autor(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public Autor()
        {
        }
    }
}
