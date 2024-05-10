namespace EstadisticasMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definir las dimensiones de la matriz
            int filas = 100;
            int columnas = 100;

            // Crear una matriz bidimensional con las dimensiones especificadas
            double[,] matriz = new double[filas, columnas];

            // Crear un generador de números aleatorios
            Random rand = new Random();

            // Llenar la matriz con números aleatorios entre 0 y 1
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = rand.NextDouble();
                }
            }

            // Calcular la media, la mediana y la desviación estándar
            double media = CalcularMedia(matriz);
            double mediana = CalcularMediana(matriz);
            double desviacionEstandar = CalcularDesviacionEstandar(matriz, media);

            // Mostrar los resultados
            Console.WriteLine($"Media: {media}");
            Console.WriteLine($"Mediana: {mediana}");
            Console.WriteLine($"Desviación Estándar: {desviacionEstandar}");
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

        // Función para calcular la mediana de los elementos de una matriz
        static double CalcularMediana(double[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            double[] elementos = new double[filas * columnas];

            // Copiar los elementos de la matriz a un arreglo unidimensional
            int index = 0;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    elementos[index] = matriz[i, j];
                    index++;
                }
            }

            // Ordenar el arreglo de elementos
            Array.Sort(elementos);

            // Calcular la mediana
            int n = elementos.Length;
            if (n % 2 == 0)
            {
                // Si hay un número par de elementos, la mediana es el promedio de los dos elementos centrales
                return (elementos[n / 2 - 1] + elementos[n / 2]) / 2.0;
            }
            else
            {
                // Si hay un número impar de elementos, la mediana es el elemento central
                return elementos[n / 2];
            }
        }

        // Función para calcular la desviación estándar de los elementos de una matriz
        static double CalcularDesviacionEstandar(double[,] matriz, double media)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            double sumaCuadrados = 0;
            int numElementos = filas * columnas;

            // Calcular la suma de los cuadrados de las diferencias con la media
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    double diferencia = matriz[i, j] - media;
                    sumaCuadrados += diferencia * diferencia;
                }
            }

            // Calcular la varianza dividiendo por el número total de elementos
            double varianza = sumaCuadrados / numElementos;

            // Calcular la desviación estándar como la raíz cuadrada de la varianza
            return Math.Sqrt(varianza);
        }
    }
}