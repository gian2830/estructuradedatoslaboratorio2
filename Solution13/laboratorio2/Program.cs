namespace MatrizAleatoria
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definir el tamaño de la matriz
            int filas = 100;
            int columnas = 100;

            // Crear una matriz bidimensional con las dimensiones especificadas
            double[,] matriz = new double[filas, columnas];

            // Crear un generador de números aleatorios
            Random rand = new Random();

            // Llenar la matriz con números aleatorios
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    // Generar un número aleatorio entre 0 y 1
                    matriz[i, j] = rand.NextDouble();
                }
            }

            // Opcional: Imprimir la matriz (descomenta esta parte si deseas imprimir la matriz)
            // ImprimirMatriz(matriz);

            Console.WriteLine("Matriz de números aleatorios de tamaño 100x100 creada con éxito.");
        }

        // Función para imprimir una matriz (opcional)
        static void ImprimirMatriz(double[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]:0.00} "); // Formateo de los números a 2 decimales
                }
                Console.WriteLine(); // Saltar a la siguiente línea después de imprimir una fila
            }
        }
    }
}