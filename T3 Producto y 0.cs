using System;

namespace T3_Producto_y_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Escribe dos numeros para determinar su producto: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 == 0)
            {
                Console.WriteLine("El producto de 0 por cualquier numero es 0.");
            }
            else
            {
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El producto de estos dos numeros es: " + (n1 * n2));
            }
        }
    }
}
