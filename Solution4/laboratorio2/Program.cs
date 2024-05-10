namespace PiramideNumerosInvertida
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario un número entero n
            Console.Write("Por favor, ingresa un número entero n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Imprimir la pirámide de números invertida del 1 al n
            Console.WriteLine($"\nPirámide de números invertida del 1 al {n}:");
            ImprimirPiramideInvertidaRecursiva(n);
        }

        // Función recursiva que imprime la pirámide de números invertida del 1 al n
        static void ImprimirPiramideInvertidaRecursiva(int n)
        {
            // Caso base: si n es menor o igual a 0, detener la recursión
            if (n <= 0)
            {
                return;
            }

            // Imprimir los números de 1 a n
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} ");
            }

            // Saltar a la siguiente línea
            Console.WriteLine();

            // Llamar recursivamente a la función con n - 1
            ImprimirPiramideInvertidaRecursiva(n - 1);
        }
    }
}