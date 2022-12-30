namespace Deber02;
using System;
using System.Diagnostics;
class OrdenacionPorInsercionPasos
{
    static void Main1(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        int[] A = new int[10];
        llenarArreglo(A);
        Console.WriteLine("\n\n############# Arreglo desordenado #############");
        imprimirArreglo(A);
        Console.WriteLine();
        stopwatch.Start();
        InsercionlinealPasos(A);
        stopwatch.Stop();
        Console.WriteLine("\n############# Arreglo Ordenado por insercion lineal: #############");
        imprimirArreglo(A);
        Console.WriteLine($"\n############# Tiempo de ejecución: {stopwatch.Elapsed} #############");
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
    static void InsercionlinealPasos(int[] A)
    {
        int i, j, aux;
        bool encontrado;
        Console.WriteLine("\nAlgoritmo de inserción lineal: ");
    for (i = 1; i < A.Length; i++)
        { 
            aux = A[i];
            j = i - 1;
            encontrado = false;
            while ((j >= 0) && !encontrado)
            {
                if (A[j] > aux)
                { 
                    A[j + 1] = A[j];
                    j--;
                }
                else
                {
                    encontrado = true;
                }
            }
            A[j + 1] = aux;
            for (int k = 0; k < A.Length; k++)
            {
                Console.Write(A[k] + " ");
            }
            Console.WriteLine();
        }
    }
}