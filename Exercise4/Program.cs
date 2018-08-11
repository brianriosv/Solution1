using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int cantpar = 0;
            int cantimpar = 0;

            Console.WriteLine("Ingresar diez numeros: ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(". ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                    cantpar += 1;
                else
                    cantimpar += 1;              
            }

            Console.WriteLine();
            Console.WriteLine("Cantidad de numeros de pares: " + cantpar);
            Console.WriteLine("Cantidad de numeros impares: " + cantimpar);
            Console.ReadLine();
        }
    }
}
