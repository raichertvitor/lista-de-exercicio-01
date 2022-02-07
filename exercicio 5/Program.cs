using System;

namespace exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu salário: ");
            double salario = Convert.ToDouble(Console.ReadLine());
            double aumento = salario + salario * 0.15;
            double final = aumento - aumento * 0.08;
            Console.WriteLine($"\nSalário: R$ {salario}");
            Console.WriteLine($"Salário com aumento de 15%: R$ {aumento}");
            Console.WriteLine($"Salário final (com descontos): R$ {final}");
        }
    }
}
