namespace Deber02;
using System;
using System.Diagnostics;
class OrdenacionBurbujaPasos
{
    static void Main1(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        int[] A = new int[10];
        llenarArreglo(A);
        Console.WriteLine("############# Arreglo desordenado #############");
        imprimirArreglo(A);
        Console.WriteLine();
        stopwatch.Start();
        OrdenamientoBurbujaPasos(A, A.Length);
        String time_elapsed = $" ---------------- Tiempo de ejecución: {stopwatch.Elapsed}----------------";
        stopwatch.Stop();
        Console.WriteLine("\n############# Arreglo Ordenado por Burbuja #############");
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
    static void OrdenamientoBurbujaPasos(int[] A, int n)
    {
        Console.WriteLine("");
        Console.WriteLine("Algoritmo Burbuja:".PadRight(35) + "\t" +
        "Cambio".PadRight(9) + "Pasada");
        int i, j, aux;
        String cadenaArreglo = ("");
        for (i = 0; i < n - 1; i++)
        {
            for (j = 0; j < n - 1 - i; j++)
            {
                if (A[j] > A[j + 1])
                {
                    aux = A[j];
                    A[j] = A[j + 1];
                    A[j + 1] = aux;
                }
                for (int k = 0; k < A.Length; k++)
                {
                    cadenaArreglo += A[k] + " ";
                }
                Console.WriteLine(cadenaArreglo.PadRight(32) + "\t" +
                A[j].ToString().PadRight(3) + " " + A[j + 1].ToString().PadRight(9) +
                (i).ToString());
                cadenaArreglo = ("");
            }
        }
    }
}