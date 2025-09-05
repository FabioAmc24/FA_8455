using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer2();
            Console.ReadKey();  



        }

        static void ejer1()
        {
            string nombre, carrera;
            Console.Write("Ingresa su nomnbre: ");
            nombre= Console.ReadLine();
            Console.Write("INgrese su carrera: ");
            carrera= Console.ReadLine();

            Console.WriteLine($"\n {nombre} bienvenido al curso de fundamentos algoritmicos de {carrera}");

        }
        static void ejer2()
        {
            Console.WriteLine("\"Fabinho\"");
        }

    }
}
