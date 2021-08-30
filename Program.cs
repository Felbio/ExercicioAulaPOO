using System;

namespace Saque
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crie um algoritmo que leia um saque, 
            // em dinheiro e calcule a quantidade de notas de 100, 50, 10, 5, 2 e 1 real 
            //necessarias para efetuar esses saque;
            //Entrada
            int saque, n200, n100, n50, n20, n10, n5, n2, n1;
            Console.WriteLine("Saque num caixa eletrônico");
            Console.WriteLine("Digite o saque em reais: ");
            saque = int.Parse(Console.ReadLine());
            //Procesamento
            n200 = saque / 200;
            n100 = (saque % 200) / 100;
            n50 = ((saque % 200) % 100) / 50;
            n20 = (((saque % 200) % 100) % 50) / 20;
            n10 = ((((saque % 200) % 100) % 50) % 20) / 10;
            n5 = (((((saque % 200) % 100) % 50) % 20) % 10) / 5;
            n2 = (((((saque % 200) % 100) % 50) % 20) % 10 % 5) / 2;
            n1 = ((((((saque % 200) % 100) % 50) % 20) % 10) / 2) % 2;

            //Saída
            
            Console.WriteLine("\n\n O saque de R$" + saque + " nos fornece: \n");
            Console.WriteLine(n200 + " notas de R$200,00 \n " + n100 + " notas de R$100,00 ");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(n50 + " notas de R$50,00 \n " + n20 + " notas de R$20,00 "); 
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(n10 + " notas de R$10,00 \n " + n5 + " notas de R$5,00 ");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(n2 + " notas de R$2,00 \n " + n1 + " notas de R$1,00 ");
            Console.WriteLine("---------------------------------------------------");
            Console.ReadKey();
        }
    }
}
