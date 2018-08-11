using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            char iter = 's';
            int factorial = 1; //...

            while (iter == 's') {
                Console.Write("Ingrese un numero: ");
                int num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    Console.WriteLine("El numero es negativo.");
                }
                else
                {
                    for (int i = 1; i <= num; i++)
                    {
                        factorial *= i;
                    }
                    Console.Write("El factorial de " + num + " es: " + factorial + "   ");
                }
                Console.WriteLine("¿Desea continuar (S/N)?");
                iter = char.Parse(Console.ReadLine());
                factorial = 1;
            }
            
        }
    }
}
