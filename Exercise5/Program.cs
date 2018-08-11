using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            float sum = 0;
            float cont = 0;
            float prom;
            int cantnum;
            int num;

            Console.Write("Cantidad de numero a ingresar: ");
            cantnum = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Ingrese los numeros: ");
            Console.WriteLine();

            for (int i = 0; i < cantnum; i++)
            {
                Console.Write(". ");
                num = int.Parse(Console.ReadLine());

                sum += num;
                cont++;
            }

            prom = sum / cont;
            Console.WriteLine();
            Console.WriteLine("La sumatoria es: " + sum);
            Console.WriteLine("El promedio es: " + prom);
            Console.ReadLine();
        }
    }
}
