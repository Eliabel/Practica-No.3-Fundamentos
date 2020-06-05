using System;

namespace T3_Multiplo_de_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Escribe un numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 % 10 == 0)
            {
                Console.WriteLine("El primero es multiplo de 10.");
                Console.WriteLine("Escribe otro numero");
                n2 = Convert.ToInt32(Console.ReadLine());
                if (n2 % 10 == 0) 
                {
                    Console.WriteLine("El segundo tambien es multiplo de 10.");
                }
                else
                {
                    Console.WriteLine("El segundo NO es multiplo de 10.");
                }
            }
            else
            {
                Console.WriteLine("El primero NO es multiplo de 10.");
            }

        }
    }
}
