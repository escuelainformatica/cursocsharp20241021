
using ConsoleApp7.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.servicio
{
    internal class AutoSrv
    {
        public static void Mostrar(Autor autor)
        {
            //Console.WriteLine(autor.Nombre);
            Console.WriteLine($"Autor:{autor.Nombre}, Apellido:{autor.Apellido}, Genero:{autor.Genero}");
        }
    }
}
