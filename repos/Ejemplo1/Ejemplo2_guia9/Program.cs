using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2_guia9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] nombres;
            int[] libretas;
            int[] notas;

            int alumnoL;
            string alumnoN;
            int alumnoNota;

            int contadorL;
            int contadorN;
            int contador



            nombres = new string[1000];

            libretas = new int[100];

            notas = new int[100];

            Console.WriteLine("Ingresar el numero de libreta (-1 para salir)");
            alumnoL = Convert.ToInt32(Console.ReadLine());



            while (alumnoL !=-1)
            {
                Console.WriteLine("Ingresar el nombre del alumno");
                alumnoN = (Console.ReadLine());


                Console.WriteLine("Ingresar la nota del alumno");
                alumnoNota = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}
