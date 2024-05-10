namespace MediaMatriz
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

            // Calcular la media de los elementos de la matriz
            double media = CalcularMedia(matriz);

            // Imprimir la media de los elementos de la matriz
            Console.WriteLine($"\nLa media de los elementos de la matriz es: {media}");
        }

        // Función para calcular la media de los elementos de una matriz
        static double CalcularMedia(double[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            double suma = 0;
            int numElementos = filas * columnas;

            // Sumar todos los elementos de la matriz
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    suma += matriz[i, j];
                }
            }

            // Calcular la media dividiendo la suma por el número de elementos
            return suma / numElementos;
        }
    }
}