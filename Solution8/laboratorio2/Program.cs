namespace MatrizDeMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario el número de submatrices (filas)
            Console.Write("Ingresa el número de submatrices (filas): ");
            int numSubmatrices = Convert.ToInt32(Console.ReadLine());

            // Crear una matriz de matrices con el número de submatrices especificado
            double[][] matrizDeMatrices = new double[numSubmatrices][];

            // Llenar la matriz de matrices con valores proporcionados por el usuario
            for (int i = 0; i < numSubmatrices; i++)
            {
                // Solicitar al usuario el tamaño de la submatriz actual
                Console.Write($"Ingresa el número de elementos en la submatriz {i}: ");
                int numElementos = Convert.ToInt32(Console.ReadLine());

                // Crear la submatriz con el tamaño especificado
                matrizDeMatrices[i] = new double[numElementos];

                // Solicitar al usuario que ingrese los valores para la submatriz actual
                Console.WriteLine($"Ingresa los valores para la submatriz {i}:");
                for (int j = 0; j < numElementos; j++)
                {
                    Console.Write($"Elemento {j}: ");
                    matrizDeMatrices[i][j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            // Imprimir la matriz de matrices
            Console.WriteLine("\nLa matriz de matrices es:");
            ImprimirMatrizDeMatrices(matrizDeMatrices);
        }

        // Función para imprimir una matriz de matrices
        static void ImprimirMatrizDeMatrices(double[][] matrizDeMatrices)
        {
            for (int i = 0; i < matrizDeMatrices.Length; i++)
            {
                for (int j = 0; j < matrizDeMatrices[i].Length; j++)
                {
                    Console.Write($"{matrizDeMatrices[i][j]} ");
                }
                Console.WriteLine(); // Saltar a la siguiente línea después de imprimir una submatriz
            }
        }
    }
}