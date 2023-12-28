using System;

namespace _04Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            int eleitores, brancos, nulos, validos, resultado2, resultado3, resultado4;
            
            Console.WriteLine("Total de eleitores:");
            eleitores = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Total de votos em branco:");
            brancos = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Total de votos nulos:");
            nulos = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Total de votos válidos:");
            validos = Int32.Parse(Console.ReadLine());


            resultado2 = brancos * 100/eleitores;
            resultado3 = nulos * 100 /eleitores;
            resultado4 = validos * 100/eleitores;

            Console.WriteLine("Total de eleitores:" +eleitores);
            Console.WriteLine("Votos brancos: "+resultado2+"%");
            Console.WriteLine("Votos nulos: "+resultado3+"%");
            Console.WriteLine("Votos válidos: "+resultado4+"%");

            //Ultima aula foi a 4/50


        }
    }
}
