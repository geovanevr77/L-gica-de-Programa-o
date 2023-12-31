using System;

namespace _07Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeticao = 0;

            while(repeticao < 3)
            {
            Console.WriteLine("Digite um valor:");
            int valor = Int32.Parse(Console.ReadLine());

            if(valor > 10)
            {
                Console.WriteLine("Valor maior que 10");
            }
            else
            {
                Console.WriteLine("Valor menor que 10");
            }
            repeticao++;
            }
        }
    }
}