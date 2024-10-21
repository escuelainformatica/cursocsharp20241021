using ConsoleApp7.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.servicio
{
    internal class LibroSrv
    {
        public static void Mostrar(Libro libro)
        {
            // quiero mostrar el titulo y el autor
            Console.WriteLine($"Titulo:{libro.Titulo}, Autor:{libro.Autor.Nombre} {libro.Autor.Apellido}");
        }
    }
}
