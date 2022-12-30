namespace Deber02;
class OrdenacionQuicksort
{
    static void Main1(string[] args)
    {
        int[] A = new int[20];
        llenarArreglo(A);
        Console.WriteLine("\n\n############# Arreglo desordenado #############");
        imprimirArreglo(A);

        QuickSort(A, 0, A.Length - 1);
        Console.WriteLine("\n\n############# Arreglo Ordenado por Quicksort #############");
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
    static void QuickSort(int[] a, int primero, int ultimo)
    {
        int i, j, central, pivote;
        central = (primero + ultimo) / 2;
        pivote = a[central];
        i = primero;
        j = ultimo;
        do
        {
            while (a[i] < pivote) i++;
            while (a[j] > pivote) j--;
            if (i <= j)
            {
                int tmp;
                tmp = a[i];
                a[i] = a[j];
                a[j] = tmp; /* intercambia a[i] con a[j] */
                i++;
                j--;
            }
        } while (i <= j);
        if (primero < j)
            QuickSort(a, primero, j); /* mismo proceso con sublista izquierda */
        if (i < ultimo)
            QuickSort(a, i, ultimo); /* mismo proceso con sublista derecha */
    }
}
