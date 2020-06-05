using System;

namespace T3_Division_y_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Escribe dos numeros para determinar su producto: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
            }
            else
            {    
                Console.WriteLine("El resultado de la division de estos dos numeros es: " + (n1 / n2));
            }
        }
    }
}
