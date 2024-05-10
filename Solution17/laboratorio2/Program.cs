namespace MatrizCovarianza
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definir las matrices como ejemplos
            double[,] matriz1 = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            double[,] matriz2 = {
                { 9, 8, 7 },
                { 6, 5, 4 },
                { 3, 2, 1 }
            };

            // Calcular la matriz de covarianza
            double[,] matrizCovarianza = CalcularMatrizCovarianza(matriz1, matriz2);

            // Imprimir la matriz de covarianza
            Console.WriteLine("Matriz de Covarianza:");
            ImprimirMatriz(matrizCovarianza);
        }

        // Función para calcular la matriz de covarianza de dos matrices
        static double[,] CalcularMatrizCovarianza(double[,] matriz1, double[,] matriz2)
        {
            // Obtener las dimensiones de las matrices
            int filas = matriz1.GetLength(0);
            int columnas = matriz1.GetLength(1);

            // Verificar si las dimensiones de las matrices son iguales
            if (filas != matriz2.GetLength(0) || columnas != matriz2.GetLength(1))
            {
                throw new ArgumentException("Las matrices deben tener las mismas dimensiones.");
            }

            // Calcular las medias de cada matriz
            double media1 = CalcularMedia(matriz1);
            double media2 = CalcularMedia(matriz2);

            // Calcular las matrices de desviación
            double[,] desviacion1 = CalcularMatrizDesviacion(matriz1, media1);
            double[,] desviacion2 = CalcularMatrizDesviacion(matriz2, media2);

            // Calcular la matriz de covarianza
            double[,] matrizCovarianza = new double[columnas, columnas];

            for (int i = 0; i < columnas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    double covarianza = 0;

                    for (int k = 0; k < filas; k++)
                    {
                        covarianza += (desviacion1[k, i] * desviacion2[k, j]);
                    }

                    matrizCovarianza[i, j] = covarianza / filas;
                }
            }

            return matrizCovarianza;
        }

        // Función para calcular la media de una matriz
        static double CalcularMedia(double[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            double suma = 0;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    suma += matriz[i, j];
                }
            }

            return suma / (filas * columnas);
        }

        // Función para calcular la matriz de desviación de una matriz
        static double[,] CalcularMatrizDesviacion(double[,] matriz, double media)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            double[,] desviacion = new double[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    desviacion[i, j] = matriz[i, j] - media;
                }
            }

            return desviacion;
        }

        // Función para imprimir una matriz
        static void ImprimirMatriz(double[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}