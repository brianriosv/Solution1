using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char iter = 's';
            int cont;
            int num;

            while (iter == 's')
            {
                cont = 0;
                Console.Write("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());

                if (num >= 2)
                {
                    for (int i = 1; i <= num; i++)
                    {
                        if (num % i == 0)
                            cont++;
                    }
                    
                    if (cont == 2)
                        Console.Write("El numero es primo. ");
                    else
                        Console.Write("El numero no es primo. ");


                    Console.WriteLine("¿Desea continuar (S/N)?");
                    iter = char.Parse(Console.ReadLine());
                }
                else
                    Console.WriteLine("NOTA: el numero debe ser mayor o igual a dos.");
                

                Console.WriteLine();
            }
        }
    }
}
