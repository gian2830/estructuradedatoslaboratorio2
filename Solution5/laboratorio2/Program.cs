namespace TablaMultiplicarRecursiva
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario un número entero n para la tabla de multiplicar
            Console.Write("Por favor, ingresa un número entero n para la tabla de multiplicar: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Imprimir la tabla de multiplicar de n de forma recursiva
            Console.WriteLine($"\nTabla de multiplicar del {n}:");
            ImprimirTablaMultiplicarRecursiva(n, 1);
        }

        // Función recursiva que imprime la tabla de multiplicar de n
        static void ImprimirTablaMultiplicarRecursiva(int n, int multiplicador)
        {
            // Caso base: si el multiplicador es mayor que 10, detener la recursión
            if (multiplicador > 10)
            {
                return;
            }

            // Imprimir el resultado de multiplicar n por el multiplicador
            Console.WriteLine($"{n} x {multiplicador} = {n * multiplicador}");

            // Llamar recursivamente a la función con el siguiente multiplicador
            ImprimirTablaMultiplicarRecursiva(n, multiplicador + 1);
        }
    }
}