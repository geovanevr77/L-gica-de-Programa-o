using System;

namespace _11Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            double numConta, saldo, deb, cred;
            double calSaldo;
            int cont = 0;

            while(cont < 2)
            {

            Console.WriteLine("Digite numero da conta: ");
            numConta = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Saldo: ");
            saldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Débito:");
            deb = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Crédito:");
            cred = Convert.ToDouble(Console.ReadLine());

            calSaldo = saldo - deb - cred;

            saldo = calSaldo;

            if(saldo >= 0)
            {
                Console.WriteLine("Saldo Positivo");
            }
            else 
            {
                Console.WriteLine("Saldo Negativo");
            }
            Console.WriteLine(saldo);
            cont++;
            }
        }
    }
}