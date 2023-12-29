using System;

namespace _05Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioFixo = 1000;
            double comFixa = 100;
            double percentual = 5;
            
            Console.WriteLine("Quantos carros vendidos:");
            double carrosVendidos = Convert.ToDouble(Console.ReadLine());
            double resultadoComissao = comFixa * carrosVendidos;

            Console.WriteLine("Valor total de vendas:");
            double totalVendas = Convert.ToDouble(Console.ReadLine());
            double porcetagemGeralVendas = totalVendas * percentual/100;

            double geral = salarioFixo + porcetagemGeralVendas + resultadoComissao;
            Console.WriteLine("Salário toral: "+geral);
            
        }
    }
}