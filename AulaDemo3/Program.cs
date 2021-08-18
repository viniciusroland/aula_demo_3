using System;

namespace AulaDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = GetDobro(4);
            var y = GetTriplo(4);
            Console.WriteLine($"Valor duplicado: {x}");
            Console.WriteLine($"Valor triplicado: {y}");
        }

        static int GetDobro(int n)
        {
            return 2 * n;
        }

        static int GetTriplo(int n)
        {
            return 3 * n;
        }
    }
}