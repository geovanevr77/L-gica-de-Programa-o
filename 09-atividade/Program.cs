using System;

namespace _09Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;

            while(cont < 3)
            {
            Console.WriteLine("Digite o primeiro valor:");
            int valor1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            int valor2 = Int32.Parse(Console.ReadLine());

            if(valor1 > valor2)
            {
                Console.WriteLine("O primeiro valor é maior que o segundo.");
            }
            else if (valor2 > valor1)
            {
                Console.WriteLine("O segundo valor é maior que o primeiro.");
            }
            else if(valor1 == valor1 || valor2 == valor1)
            {
                Console.WriteLine("Valores iguais.");
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
            cont++;
            }

        }
    }
}