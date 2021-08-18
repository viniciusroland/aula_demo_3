using System;

namespace AulaDemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = GetDobro(4);
            Console.WriteLine($"Valor: {x}");
        }

        static int GetDobro(int n)
        {
            return 2 * n;
        }
    }
}