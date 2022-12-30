namespace Deber02;
class OrdenacionBurbuja
{
    static void Main1(string[] args)
    {
        int[] A = new int[20];
        llenarArreglo(A);
        Console.WriteLine("############# Arreglo desordenado #############");
        imprimirArreglo(A);
        Console.WriteLine();

        OrdenamientoBurbuja(A, A.Length);
        Console.WriteLine("############# Arreglo Ordenado por Método Burbuja #############");
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
    static void OrdenamientoBurbuja(int[] a, int n)
    {
        int i, j;
        int aux;
        for (i = 0; i < n - 1; i++)
        { 
            for (j = 0; j < n - 1 - i; j++)
            { 
                if (a[j] > a[j + 1])
                { 
                    aux = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = aux;
                }
            }
        }
    }
}
