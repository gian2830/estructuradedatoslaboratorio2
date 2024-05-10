namespace AccederElementoCentral
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario el número de filas y columnas de la matriz
            Console.Write("Ingresa el número de filas de la matriz (debe ser impar): ");
            int filas = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Ingresa el número de columnas de la matriz (debe ser impar): ");
            int columnas = Convert.ToInt32(Console.ReadLine());

            // Verificar que filas y columnas sean impares
            if (filas % 2 == 0 || columnas % 2 == 0)
            {
                Console.WriteLine("Ambas dimensiones deben ser impares para tener un elemento central definido.");
                return;
            }

            // Crear una matriz bidimensional con las dimensiones especificadas
            double[,] matriz = new double[filas, columnas];

            // Llenar la matriz con valores proporcionados por el usuario
            Console.WriteLine("\nIngresa los valores de la matriz:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Elemento ({i}, {j}): ");
                    matriz[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            // Calcular las coordenadas del elemento central
            int filaCentral = filas / 2;
            int columnaCentral = columnas / 2;

            // Acceder y mostrar el elemento central de la matriz
            double elementoCentral = matriz[filaCentral, columnaCentral];
            Console.WriteLine($"\nEl elemento central de la matriz es: {elementoCentral}");
        }
    }
}