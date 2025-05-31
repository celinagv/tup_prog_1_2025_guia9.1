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
            #region Declarar variables
            string[] nombres;
            int[] libretas;
            int[] notas;

            string[] nombresNuevo;
            int[] libretasNuevo;
            int[] notasNuevo;

            int alumnoL;
            string alumnoN;
            int alumnoNota;

            int alumnoLNuevo;
            string alumnoNNuevo;
            int alumnoNotaNuevo;

            int contadorL;
            int acumuladorNotas = 0;
            int contadorNuevo = 0;

            double promedio;

            int mayor =0;
            int menor =0;

            int mayorL =0;
            string mayorN = null;
            int menorL = 0;
            string menorN = null;

            #endregion

            #region Construir vectores
            nombres = new string[1000];

            libretas = new int[100];

            notas = new int[100];

            nombresNuevo = new string[1000];

            libretasNuevo = new int[100];

            notasNuevo = new int[100];
            #endregion



            Console.WriteLine("Ingresar el numero de libreta (-1 para salir)");
            alumnoL = Convert.ToInt32(Console.ReadLine());
            contadorL = 0;


            while (alumnoL !=-1)
            {

                libretas[contadorL] = alumnoL;
                

                Console.WriteLine("Ingresar el nombre del alumno");
                alumnoN = (Console.ReadLine());

                nombres[contadorL] = alumnoN;
                

                Console.WriteLine("Ingresar la nota del alumno");
                alumnoNota = Convert.ToInt32(Console.ReadLine());

                notas[contadorL] = alumnoNota;
                acumuladorNotas += alumnoNota;
                


                #region Comparar nota mayor y menor
                if (contadorL == 0)
                {
                    mayor = alumnoNota;
                    menor = alumnoNota;
                    mayorL = libretas[contadorL];
                    mayorN = nombres[contadorL];
                    menorL = libretas[contadorL];
                    menorN = nombres[contadorL];
                }
                else
                {
                    if (mayor < alumnoNota)
                    {
                        mayor = alumnoNota;

                        mayorL = libretas[contadorL];
                        mayorN = nombres[contadorL]; 


                    }

                    if (menor > alumnoNota)
                    {
                        menor = alumnoNota;
                        menorL = libretas[contadorL];
                        menorN = nombres[contadorL];
                    }
                }
                #endregion
                contadorL++;

                Console.WriteLine("Ingresar el numero de libreta (-1 para salir)");
                alumnoL = Convert.ToInt32(Console.ReadLine());

            }

            if (contadorL !=0)
            {
                promedio = 1.0 *acumuladorNotas/contadorL;
                Console.WriteLine($"El promedio de las notas cargadas es {promedio}");
                Console.WriteLine($"El alumno con la mayor nota es {mayorN}, le corresponde la libreta {mayorL} y su nota es {mayor}");
                Console.WriteLine($"El alumno con la menor nota es {menorN}, le corresponde la libreta {menorL} y su nota es {menor}");

                for (int i = 0; i < contadorL; i++)
                {
                    if (promedio < notas[i])
                    {
                        alumnoLNuevo = libretas[i];
                        libretasNuevo[contadorNuevo] = alumnoLNuevo;

                        alumnoNNuevo = nombres[i];
                        nombresNuevo[contadorNuevo] = alumnoNNuevo;


                        alumnoNotaNuevo = notas[i];
                        notasNuevo[contadorNuevo] = alumnoNotaNuevo;

                        contadorNuevo++;
                    }
                }

                for (int i = 0;i<contadorNuevo;i++)
                {
                    Console.WriteLine($"Los alumnos que superan el promedio: \t Nombre: {nombresNuevo[i],5} Libreta:{libretasNuevo[i],5} Nota: {notasNuevo[i],5}");
                }
                

            }
            else
            {
                Console.WriteLine("No hay notas cargadas");
            }
            
            
        }
    }
}
