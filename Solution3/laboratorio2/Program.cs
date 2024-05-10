namespace PiramideNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario un número entero n
            Console.Write("Por favor, ingresa un número entero n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Imprimir la pirámide de números del 1 al n
            Console.WriteLine($"\nPirámide de números del 1 al {n}:");
            ImprimirPiramideRecursiva(1, n);
        }

        // Función recursiva que imprime la pirámide de números del 1 al n
        static void ImprimirPiramideRecursiva(int filaActual, int totalFilas)
        {
            // Caso base: si la fila actual es mayor que el total de filas, detener la recursión
            if (filaActual > totalFilas)
            {
                return;
            }

            // Imprimir los números de 1 a filaActual
            for (int i = 1; i <= filaActual; i++)
            {
                Console.Write($"{i} ");
            }

            // Saltar a la siguiente línea para la próxima fila
            Console.WriteLine();

            // Llamar recursivamente a la función para la siguiente fila
            ImprimirPiramideRecursiva(filaActual + 1, totalFilas);
        }
    }
}