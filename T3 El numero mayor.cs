using System;

namespace T3_El_numero_mayor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Escribe dos numeros: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine(n1+" Es el numero mayor. \n");
            }
            else
            {
                Console.WriteLine(n2 + " Es el numero mayor. \n");
            }
        }
    }
}
