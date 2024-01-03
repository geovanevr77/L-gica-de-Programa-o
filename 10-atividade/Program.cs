using System;

namespace _10Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;

            while(cont < 2)
            {
            double nota1, nota2, media;

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            if (media >= 7)
            {
                Console.WriteLine("Aprovado!!!!");
            }
            else
            {
                Console.WriteLine("Reprovado!!!");
            }
            Console.WriteLine(media);
            cont++;
            }
        }
    }
}