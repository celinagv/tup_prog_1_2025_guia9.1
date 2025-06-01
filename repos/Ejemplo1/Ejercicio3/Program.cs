using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;
            int contador = 30;

            Random aleatorios = new Random();

            numeros = new int[30];
              

            for (int i = 0; i<30; i++)
            {
                numeros[i] = i+1; 
            }
            
            Console.WriteLine("\nEl vector inicial es:");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"{numeros[i],5}");
                
            }

            for (int i = 0; i < 10; i++)
                {
                int indiceAleatorio = aleatorios.Next(0, contador);
                Console.WriteLine($"\nEl valor obtenido es: {numeros[indiceAleatorio]}");
                numeros[indiceAleatorio] = numeros[contador -1];
                contador --;
            }

            

            Console.WriteLine($"\nEl otro inicial quedo asi:");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($" {numeros[i],5}");
                
            }

            Console.ReadKey();






        }
    }
}
