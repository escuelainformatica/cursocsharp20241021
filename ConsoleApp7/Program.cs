using Biblioteca1.modelo;
using Biblioteca1.servicio;
using ConsoleApp7.modelo;
using ConsoleApp7.servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var autor1 = new Autor();
            var autor2 = new Autor("John", "Doe");
            var autor3 = new Autor("John", "Doe", "Suspenso");
            var autor4 = new Autor { Nombre="john",Apellido="doe",Genero="Suspenso"};


            var libro1 = new Libro
            {
                Titulo = "Harry Potter",
                Genero = "Fantasia",
                Autor = new Autor
                {
                    Nombre="John",
                    Apellido="Doe",
                    Genero="Autor reconocido"
                }
            };
            LibroSrv.Mostrar(libro1);


            AutoSrv.Mostrar(autor4);

            // ciudad ejemplo
            var ciudad = new Ciudad
            {
                Nombre = "Arica",
                Country = new Pais
                {
                    Nombre = "Chile",
                    Continente = new Continente
                    {
                        Nombre = "America"
                    }
                }
            };
            var america = new Continente { Nombre = "America" };
            var chile = new Pais { Nombre = "Chile", Continente = america };
            var arica = new Ciudad { Nombre = "Arica", Country = chile };

            CiudadSrv.Mostrar(arica);


            var cli = new Cliente();

            ClienteSrv.Mostrar(cli);
            


            Console.ReadKey();
        }
    }
}
