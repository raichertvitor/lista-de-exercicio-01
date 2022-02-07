using System;

namespace exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Comprimento do terreno: ");
            double comprimento = Convert.ToDouble(Console.ReadLine());
            Console.Write("Largura do terreno: ");
            double largura = Convert.ToDouble(Console.ReadLine());
            Console.Write($"\nÁrea do terreno: {comprimento * largura}");
        }
    }
}
