using System;

namespace exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            
            Console.Write("Digite sua idade: ");
            double idade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\n{nome}, você já viveu {idade * 365} dias");

            if (idade > 35)
            {
                Console.WriteLine("\nJá está velho demais!");
            }
            else
            {
                Console.WriteLine("\nTá novo ainda!");
            }
        }
    }
}
