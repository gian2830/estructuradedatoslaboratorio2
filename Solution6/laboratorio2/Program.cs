namespace MatrizNumerosReales
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define las dimensiones de la matriz
            Console.Write("Ingresa el número de filas de la matriz: ");
            int filas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el número de columnas de la matriz: ");
            int columnas = Convert.ToInt32(Console.ReadLine());

            // Crea una matriz de números reales (double) con las dimensiones especificadas
            double[,] matriz = new double[filas, columnas];

            // Llenar la matriz con valores proporcionados por el usuario
            Console.WriteLine("Ingresa los valores de la matriz:");

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Matriz[{i}, {j}]: ");
                    matriz[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            // Imprimir la matriz
            Console.WriteLine("\nLa matriz es:");
            ImprimirMatriz(matriz);
        }

        // Función que imprime una matriz de números reales
        static void ImprimirMatriz(double[,] matriz)
        {
            // Recorre filas
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                // Recorre columnas
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine(); // Saltar a la siguiente línea después de imprimir una fila
            }
        }
    }
}