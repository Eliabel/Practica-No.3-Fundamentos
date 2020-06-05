using System;

namespace T3_Numero_positivo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Escribe dos numeros enteros: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            if(n1>0 && n2 > 0)
            {                
                Console.WriteLine("Los dos numeros son positivos");
            }
            else if (n1 > 0 || n2 > 0)
            {
                Console.WriteLine("Uno de los dos numeros es positivos");
            }
            else
            {
                Console.WriteLine("Ninguno de los dos numeros son positivos");

            }
        }
    }
}
