namespace MultiplicacionMatrizNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario el número de filas y columnas de la matriz
            Console.Write("Ingresa el número de filas de la matriz: ");
            int filas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el número de columnas de la matriz: ");
            int columnas = Convert.ToInt32(Console.ReadLine());

            // Crear una matriz bidimensional con las dimensiones especificadas
            double[,] matriz = new double[filas, columnas];

            // Llenar la matriz con valores proporcionados por el usuario
            Console.WriteLine("\nIngresa los valores de la matriz:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Matriz[{i}, {j}]: ");
                    matriz[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            // Solicitar al usuario el número por el que se quiere multiplicar la matriz
            Console.Write("\nIngresa el número por el que deseas multiplicar la matriz: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            // Multiplicar la matriz por el número
            double[,] matrizResultado = MultiplicarMatrizPorNumero(matriz, numero);

            // Imprimir la matriz resultante
            Console.WriteLine("\nLa matriz resultante de multiplicar la matriz por el número es:");
            ImprimirMatriz(matrizResultado);
        }

        // Función para multiplicar una matriz por un número
        static double[,] MultiplicarMatrizPorNumero(double[,] matriz, double numero)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            double[,] resultado = new double[filas, columnas];

            // Multiplica cada elemento de la matriz por el número
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    resultado[i, j] = matriz[i, j] * numero;
                }
            }

            return resultado;
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