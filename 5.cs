namespace Deber02;
class OrdenacionPorInsercion
{
    static void Main1(string[] args)
    {
        int[] A = new int[20];
        llenarArreglo(A);
        Console.WriteLine("\n\n############# Arreglo desordenado #############");
        imprimirArreglo(A);
        ordenacionInsercion(A);
        Console.WriteLine("\n\n############# Arreglo Ordenado por insercion lineal #############");
        imprimirArreglo(A);

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
    static void ordenacionInsercion(int[] A)
    {
        int i, j, aux;
        bool encontrado;
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
        }
    }
}