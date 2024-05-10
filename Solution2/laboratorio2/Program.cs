namespace SumaRecursiva
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario un número entero 'n'
            Console.Write("Por favor, ingresa un número entero n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Calcular la suma recursiva del 1 al n
            int suma = SumaRecursiva(1, n);

            // Mostrar el resultado
            Console.WriteLine($"\nLa suma de los números del 1 al {n} es: {suma}");
        }

        // Función recursiva que calcula la suma de los números del 1 al n
        static int SumaRecursiva(int inicio, int fin)
        {
            // Caso base: si el número actual es igual a fin, devuelve el número actual
            if (inicio > fin)
            {
                return 0;
            }
            // Llamada recursiva: sumar el número actual con el resultado de la función llamada con inicio + 1
            return inicio + SumaRecursiva(inicio + 1, fin);
        }
    }
}