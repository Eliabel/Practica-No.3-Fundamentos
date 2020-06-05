using System;

namespace T3_Multiplo_de_4_o_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Escribe un numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 % 4 == 0)
            {
                Console.WriteLine("Es multiplo de 4.");
            }else if(n1 % 5 == 0)
            {
                Console.WriteLine("Es multiplo de 5.");
            }
            else 
            {
                Console.WriteLine("El numero no es multiplo de 4 ni de 5.");
            }

        }
    }
}
