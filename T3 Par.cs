using System;

namespace T3_PAR
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Escribe el numero para saber si es par: ");
            n = Convert.ToInt32(Console.ReadLine());
            if ((n % 2) == 0){ 
                Console.WriteLine("El numero es par.");
                    }else
                Console.WriteLine("El numero es impar.");
        }
    }
}
