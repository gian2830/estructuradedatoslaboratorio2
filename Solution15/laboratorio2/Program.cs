namespace MaximoMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definir las dimensiones de la matriz
            int filas = 3;
            int columnas = 3;

            // Crear una matriz bidimensional
            int[,] matriz = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            // Encontrar el elemento máximo
            int maximo = EncontrarMaximo(matriz);

            // Imprimir el resultado
            Console.WriteLine($"El elemento máximo de la matriz es: {maximo}");
        }

        // Función para encontrar el elemento máximo de una matriz
        static int EncontrarMaximo(int[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            int maximo = matriz[0, 0]; // Suponemos que el primer elemento es el máximo

            // Recorremos la matriz para encontrar el máximo
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i, j] > maximo)
                    {
                        maximo = matriz[i, j];
                    }
                }
            }

            return maximo;
        }
    }
}