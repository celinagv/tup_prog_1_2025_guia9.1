using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;

            int contador;
            int acumulador = 0;
            double promedio;
            int mayor = 0;

            numeros = new int[100];

            Console.WriteLine("Ingrese el valor");

            int valor = Convert.ToInt32(Console.ReadLine());

            if(valor!=-1)
                mayor = valor;

            contador = 0;

            while (valor !=-1)
            {
                numeros[contador] = valor;
                mayor = Math.Max(valor, mayor);
                contador++; 

                Console.WriteLine("Ingrese el valor");
                valor = Convert.ToInt32(Console.ReadLine());

                

            }




            for (int n = 0; n < contador; n++)
            {
                Console.WriteLine($"{numeros[n],3}");
                acumulador += numeros[n];

              
                
            }
            promedio = 1.0 * acumulador / contador;
            Console.WriteLine($"{promedio}");

            Console.WriteLine($"Mayor: {mayor}");
        }
    }
}
