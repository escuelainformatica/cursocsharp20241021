using Biblioteca1.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1.servicio
{
    public class ClienteSrv
    {
        public static void Mostrar(Cliente cli)
        {
            Console.WriteLine(cli.Nombre);
        }
    }
}
