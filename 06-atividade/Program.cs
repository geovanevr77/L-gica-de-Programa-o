using System;

namespace _06Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1, N2, N3, media;

            Console.WriteLine("Primeira nota:");
            N1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Segunda nota:");
            N2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Terceira nota:");
            N3 = Convert.ToDouble(Console.ReadLine());

            media = N1 * 2 + N2 * 3 + N3 * 5 / 10;
            Console.WriteLine("Media: "+media);
        }
    }
}

//7