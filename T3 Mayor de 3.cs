using System;

namespace T3_Mayor_de_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Escriba tres numeros reales para determinar el mayor: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            if((n1>n2) && (n1 > n3))
            {
                Console.WriteLine(n1+" Es el mayor numero de todos.");
            }else if((n2>n1) && (n2 > n3))
            {
                Console.WriteLine(n2 + " Es el mayor numero de todos.");

            }
            else
            {
                Console.WriteLine(n3 + " Es el mayor numero de todos.");

            }
        }
    }
}
