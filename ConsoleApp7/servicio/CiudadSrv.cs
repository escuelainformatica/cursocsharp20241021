using ConsoleApp7.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.servicio
{
    internal class CiudadSrv
    {
        public static void Mostrar(Ciudad ciudad)
        {
            Console.WriteLine($"{ciudad.Nombre},{ciudad.Country.Nombre},{ciudad.Country.Continente.Nombre}");
        }
    }
}
