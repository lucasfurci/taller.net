using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio_Clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1: Armar una clase que funcione como calculadora.
            //-Las cuentas se reciben como una cadena ej "1+2"
            //Mejorar la calculadora para que pueda imprimir la tira de operaciones.
            //-Para operar con el titulo 

            Console.WriteLine("Ingrese cuenta:");
            string console = Console.ReadLine();

            string primerOperador;
            string segundoOperador;
            string operador;
            string cadena; 

            foreach (var item in cadena)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < cadena.Length ; i++)

            {
                int valor;
                if(int.TryParse(cadena[i].toString(), out valor))
                {
                    Console.Write(cadena[i]);
                    Console.WriteLine(" es un numero");

                }
            }


        }
    }
}
