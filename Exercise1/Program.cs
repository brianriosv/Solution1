using System;

namespace Solucion1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (num > 0)
                Console.WriteLine("El numero es positivo.");
            else
                Console.WriteLine("El numero es negativo.");
            
            if (num % 2 == 0)
                Console.WriteLine("El numero es par.");
            else
                Console.WriteLine("El numero es impar.");
            

            Console.WriteLine("Divisores: ");
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(". " + i);
                }
            }
            Console.ReadLine();
        }

        
    }
}
