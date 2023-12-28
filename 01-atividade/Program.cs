using System;

namespace _01Atividade
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("QNT alunos: ");
            int qntAluno = Int32.Parse(Console.ReadLine());
            int condicao = qntAluno;

            while(condicao <= 5)
            {
            Console.WriteLine("Digite a Base do triangulo:");
            double baseTriangulo = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do triangulo:");
            double alturaTriangulo = Double.Parse(Console.ReadLine());

            Console.WriteLine("Altura: "+alturaTriangulo+", Base: "+baseTriangulo);

            double calculo = alturaTriangulo * baseTriangulo /2;

            Console.WriteLine("A area do triangulo é: "+calculo);
            }
            Console.Write("Fim");
        }
    }    
}
