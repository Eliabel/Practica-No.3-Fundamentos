using System;

namespace T3_El_Multiplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Escribe dos numeros: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 % n2 == 0)
            {
                Console.WriteLine("El primero es multiplo del segundo.");
            }
            else
            {
                Console.WriteLine("El primero NO es multiplo del segundo.");
            }
                
        }
    }
}
