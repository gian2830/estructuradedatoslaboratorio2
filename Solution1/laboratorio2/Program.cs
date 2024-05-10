namespace NumerosParesRecursivos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Imprimir los números pares del 1 al 100
            Console.WriteLine("Números pares del 1 al 100:");
            ImprimirNumerosParesRecursivos(1);
        }

        // Función recursiva que imprime los números pares del 1 al 100
        static void ImprimirNumerosParesRecursivos(int numero)
        {
            // Verificar si el número actual es mayor que 100
            if (numero > 100)
            {
                // Si es mayor, detener la recursión
                return;
            }

            // Verificar si el número actual es par
            if (numero % 2 == 0)
            {
                // Si es par, imprimir el número
                Console.WriteLine(numero);
            }

            // Llamar a la función recursivamente con el siguiente número
            ImprimirNumerosParesRecursivos(numero + 1);
        }
    }
}