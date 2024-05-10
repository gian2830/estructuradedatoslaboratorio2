namespace SumaMatricesDiferentes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar dimensiones de la primera matriz
            Console.Write("Ingresa el número de filas de la primera matriz: ");
            int filas1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el número de columnas de la primera matriz: ");
            int columnas1 = Convert.ToInt32(Console.ReadLine());

            // Crear la primera matriz con dimensiones especificadas
            double[,] matriz1 = new double[filas1, columnas1];

            // Llenar la primera matriz con valores proporcionados por el usuario
            Console.WriteLine("\nIngresa los valores de la primera matriz:");
            for (int i = 0; i < filas1; i++)
            {
                for (int j = 0; j < columnas1; j++)
                {
                    Console.Write($"Matriz1[{i}, {j}]: ");
                    matriz1[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            // Solicitar dimensiones de la segunda matriz
            Console.Write("\nIngresa el número de filas de la segunda matriz: ");
            int filas2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el número de columnas de la segunda matriz: ");
            int columnas2 = Convert.ToInt32(Console.ReadLine());

            // Crear la segunda matriz con dimensiones especificadas
            double[,] matriz2 = new double[filas2, columnas2];

            // Llenar la segunda matriz con valores proporcionados por el usuario
            Console.WriteLine("\nIngresa los valores de la segunda matriz:");
            for (int i = 0; i < filas2; i++)
            {
                for (int j = 0; j < columnas2; j++)
                {
                    Console.Write($"Matriz2[{i}, {j}]: ");
                    matriz2[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            // Calcular las dimensiones de la matriz de suma (mínimo de filas y columnas de ambas matrices)
            int filasSuma = Math.Min(filas1, filas2);
            int columnasSuma = Math.Min(columnas1, columnas2);

            // Crear una matriz para almacenar la suma
            double[,] matrizSuma = new double[filasSuma, columnasSuma];

            // Realizar la suma de los elementos coincidentes de ambas matrices
            for (int i = 0; i < filasSuma; i++)
            {
                for (int j = 0; j < columnasSuma; j++)
                {
                    matrizSuma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            // Imprimir la matriz de suma
            Console.WriteLine("\nLa matriz de suma es:");
            ImprimirMatriz(matrizSuma);
        }

        // Función para imprimir una matriz
        static void ImprimirMatriz(double[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine(); // Saltar a la siguiente línea después de imprimir una fila
            }
        }
    }
}