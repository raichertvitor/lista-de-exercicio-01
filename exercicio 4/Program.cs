using System;

namespace exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Temperatura em graus Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahr = (celsius * 1.8 + 32);
            Console.WriteLine($"Temperatura em graus Fahrenheit: {fahr}");
        }
    }
}
