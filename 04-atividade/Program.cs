using System;

namespace _04Atividade
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Digite seu salário: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite seu salário: ");
            double percentual = Convert.ToDouble(Console.ReadLine());

            double resultado = percentual * salario/100;
            double saldoNovo = salario + resultado;

            Console.WriteLine("O reajuste é de: "+saldoNovo);
        } 
    }
}