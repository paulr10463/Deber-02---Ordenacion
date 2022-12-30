namespace Deber02;
class OrdenacionPorSeleccion
{
    static void Main1(string[] args)
    {
        int[] A = new int[20];
        llenarArreglo(A);
        Console.WriteLine("\n############# Arreglo desordenado ############# ");
        imprimirArreglo(A);
        Console.WriteLine();
        Seleccion(A, A.Length);
        Console.WriteLine("\n\n############# Arreglo Ordenado por Seleccion #############");
        imprimirArreglo(A);
        Console.WriteLine();
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
            A[indiceMenor] = A[i];
            A[i] = aux;
        }
    }
}
