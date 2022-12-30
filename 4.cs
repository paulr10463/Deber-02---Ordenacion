namespace Deber02;
using System;
using System.Diagnostics;
class OrdenacionPorSeleccionPasos
{
    static void Main1(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        int[] A = new int[10];
        llenarArreglo(A);
        Console.WriteLine("\n############# Arreglo desordenado: ############# ");
        imprimirArreglo(A);
        Console.WriteLine();
        stopwatch.Start();
        Seleccion(A, A.Length);
        String time_elapsed = $"############# Tiempo de ejecución: {stopwatch.Elapsed} #############";
        stopwatch.Stop();
        Console.WriteLine("\n############# Arreglo Ordenado por Método de seleccion #############");
        imprimirArreglo(A);
        Console.WriteLine($"\n\n{time_elapsed}");
    }
    static void imprimirArreglo(int[] A)
    {
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write(A[i] + " ");
        }
    }
    static void llenarArreglo(int[] A)
    {
        Random rand = new Random();
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = rand.Next(1, 101);
        }
    }
    static void Seleccion(int[] A, int n)
    {
        int i, j, indiceMenor, aux;
        String ini = "\nComienzo del algoritmo de selección:";
        Console.WriteLine(ini.PadRight(35) + "\t" +
        "Cambio".PadRight(9) + "Pasada");
        String cadenaArreglo = ("");
        for (i = 0; i < n - 1; i++)
        {
            indiceMenor = i; 
            for (j = i + 1; j < n; j++)
            {
                if (A[j] < A[indiceMenor])
                {
                    indiceMenor = j; 
                }
            }
            aux = A[indiceMenor];                           
            String a = A[indiceMenor].ToString();
            A[indiceMenor] = A[i];
            String b = A[i].ToString();
            A[i] = aux;
            for (int k = 0; k < A.Length; k++)
            {
                cadenaArreglo += A[k] + " ";
            }
            Console.WriteLine(cadenaArreglo.PadRight(35) + "\t" +
            a.PadRight(3) + " " + b.PadRight(9) + (i).ToString());
            cadenaArreglo = ("");
        }
    }
}