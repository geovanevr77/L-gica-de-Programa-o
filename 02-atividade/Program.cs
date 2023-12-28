using System;


namespace _02Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            int anos, meses, dias;
            
            Console.WriteLine("Qual a sua idade?");
            int idade = Int32.Parse(Console.ReadLine());

            anos = idade;

            meses = idade * 12;

            dias = anos * 365;

            Console.WriteLine("Essa pessoa tem "+anos+" anos, "+meses+" meses e "+dias+" dias.");

            
            
        }
    }
}