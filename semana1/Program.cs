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
            ejer3();
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
        static void ejer3()
        {
            Console.WriteLine("Ingrese num 1: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese num 2: ");
            int y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\nSuma: " + (x+y));
            Console.WriteLine("Resta: " + (x - y));
            Console.WriteLine("Multiplicacion: "+(x*y));
            Console.WriteLine("Division: " + divi);



        }
    }
}
