using System.Numerics;

namespace MatrizNumerosComplejos
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

            // Crear una matriz de números complejos con las dimensiones especificadas
            Complex[,] matriz = new Complex[filas, columnas];

            // Llenar la matriz con valores proporcionados por el usuario
            Console.WriteLine("\nIngresa los valores de la matriz de números complejos:");

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine($"Valores para Matriz[{i}, {j}]:");
                    Console.Write("Parte real: ");
                    double parteReal = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Parte imaginaria: ");
                    double parteImaginaria = Convert.ToDouble(Console.ReadLine());

                    // Crear un número complejo con los valores ingresados
                    matriz[i, j] = new Complex(parteReal, parteImaginaria);
                }
            }

            // Imprimir la matriz
            Console.WriteLine("\nLa matriz de números complejos es:");
            ImprimirMatriz(matriz);
        }

        // Función para imprimir una matriz de números complejos
        static void ImprimirMatriz(Complex[,] matriz)
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