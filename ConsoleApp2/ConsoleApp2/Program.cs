using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1: Realizar un programa de consola que permita ingresar el nombre y apellido 
            //por separado, con estos datos debe imprimir un mensaje con el nombre completo.

            Console.Write("Nombre: ");

            var nombre = Console.ReadLine();

            Console.Write("Apellido: ");

            var apellido = Console.ReadLine();

            Console.WriteLine(nombre + " " + apellido);

            Console.ReadKey();

            //Ejercicio 2: Realizar un programa de consola que permita ingresar el nombre y la edad, 
            //con estos datos debe imprimir un mensaje diciendo si es mayor de edad o no.

            Console.Write("Nombre: ");

            var nombre2 = Console.ReadLine();

            Console.Write("Edad: ");

            int edad;

            int.TryParse(Console.ReadLine(), out edad);

            if (edad >= 18)
            {
                Console.Write("ES MAYOR DE EDAD");
            }
            else
            {
                Console.Write("ES MENOR DE EDAD");
            }

            Console.ReadKey();
        }
    }
}
