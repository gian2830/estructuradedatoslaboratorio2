namespace SubmatrizMayorSuma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definir una matriz como ejemplo
            int[,] matriz = {
                { 1, 2, -1, -4, -20 },
                { -8, -3, 4, 2, 1 },
                { 3, 8, 10, 1, 3 },
                { -4, -1, 1, 7, -6 }
            };

            // Encontrar la submatriz de mayor suma
            int[,] submatriz = EncontrarSubmatrizMayorSuma(matriz);

            // Imprimir la submatriz de mayor suma
            Console.WriteLine("La submatriz de mayor suma es:");
            ImprimirMatriz(submatriz);
        }

        // Función para encontrar la submatriz de mayor suma
        static int[,] EncontrarSubmatrizMayorSuma(int[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            // Variables para almacenar la suma máxima y la submatriz resultante
            int maxSuma = int.MinValue;
            int[,] submatrizMaxSuma = new int[2, 2];

            // Variables para almacenar las coordenadas de la submatriz resultante
            int filaInicio = 0, filaFin = 0, colInicio = 0, colFin = 0;

            // Iterar sobre todas las filas
            for (int inicioFila = 0; inicioFila < filas; inicioFila++)
            {
                // Arreglo para almacenar la suma acumulada de cada columna
                int[] sumaColumna = new int[columnas];

                // Iterar sobre todas las filas finalizadas
                for (int finFila = inicioFila; finFila < filas; finFila++)
                {
                    // Calcular la suma acumulada de cada columna para las filas desde inicioFila hasta finFila
                    for (int j = 0; j < columnas; j++)
                    {
                        sumaColumna[j] += matriz[finFila, j];
                    }

                    // Aplicar el algoritmo de Kadane para encontrar la suma máxima de una submatriz 1D
                    int sumaMaxima = int.MinValue;
                    int sumaActual = 0;
                    int inicioCol = 0;

                    for (int j = 0; j < columnas; j++)
                    {
                        sumaActual += sumaColumna[j];
                        if (sumaActual < 0)
                        {
                            sumaActual = 0;
                            inicioCol = j + 1;
                        }
                        else if (sumaActual > sumaMaxima)
                        {
                            sumaMaxima = sumaActual;
                            filaInicio = inicioFila;
                            filaFin = finFila;
                            colInicio = inicioCol;
                            colFin = j;
                        }
                    }

                    // Actualizar la suma máxima global y la submatriz resultante
                    if (sumaMaxima > maxSuma)
                    {
                        maxSuma = sumaMaxima;
                        submatrizMaxSuma[0, 0] = filaInicio;
                        submatrizMaxSuma[0, 1] = colInicio;
                        submatrizMaxSuma[1, 0] = filaFin;
                        submatrizMaxSuma[1, 1] = colFin;
                    }
                }
            }

            // Construir y devolver la submatriz de mayor suma
            int[,] submatriz = new int[submatrizMaxSuma[1, 0] - submatrizMaxSuma[0, 0] + 1, submatrizMaxSuma[1, 1] - submatrizMaxSuma[0, 1] + 1];
            for (int i = submatrizMaxSuma[0, 0], k = 0; i <= submatrizMaxSuma[1, 0]; i++, k++)
            {
                for (int j = submatrizMaxSuma[0, 1], l = 0; j <= submatrizMaxSuma[1, 1]; j++, l++)
                {
                    submatriz[k, l] = matriz[i, j];
                }
            }

            return submatriz;
        }

        // Función para imprimir una matriz
        static void ImprimirMatriz(int[,] matriz)
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