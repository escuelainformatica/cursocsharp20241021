using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.modelo
{
    internal class Libro
    {
        public string Titulo { set; get; }
        public string Genero { set; get; }

        public Autor Autor { set; get; }
    }
}
