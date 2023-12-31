using System;

namespace _08Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor: ");
            int valor = Int32.Parse(Console.ReadLine());

            if(valor >= 0)
            {
                Console.WriteLine("Valor positivo");
            }
            else
            {
                Console.WriteLine("Valor negativo");
            }
            
        }
    }
}

