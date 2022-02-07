using System;

namespace exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Preço do pãozinho R$ 0,12");
            Console.WriteLine("Preço da broa R$ 1,50");
            Console.Write("\nNúmero de pães vendidos: ");
            double paes = Convert.ToDouble(Console.ReadLine());
            Console.Write("Número de broas vendidas: ");
            double broas = Convert.ToDouble(Console.ReadLine());

            double valorPaes = paes * 0.12;
            double valorBroas = broas * 1.50;
            double ganhos = valorPaes + valorBroas;
            Console.Write($"\nGanhos do dia: R$ {ganhos}");

            Console.WriteLine($"\nGuardar na poupança: R$ {ganhos * 0.10}");
        }
    }
}
