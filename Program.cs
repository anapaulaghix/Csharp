using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int op, n1, n2;
            string opcao="s";

            Console.WriteLine("Digite 1: Insira um número para o programa dizer se ele é par ou ímpar.");
            Console.WriteLine("Digite 2: Insira um número para o programa exibilo em ordem decrescente até zero.");
            Console.WriteLine("Digite 3: Encerrar o Programa."); 

            Console.WriteLine("Insira o número da opção escolhida:");
            op = int.Parse(Console.ReadLine()); 

           while (opcao =="s")
           {
               switch (op)
            {
                case 1:
                Console.WriteLine("Insira um número:");
                n1 = int.Parse(Console.ReadLine());

                if (n1 % 2 == 0)
                {
                    Console.WriteLine("O número {0} é par.", n1);
                }
                else
                {
                    Console.WriteLine("O número {0} é ímpar.", n1);
                }
                break;

                case 2: 
                Console.WriteLine("Insira um número:");
                n2 = int.Parse(Console.ReadLine());

                while (n2 > 0)
                {
                    Console.WriteLine(n2 - 1);
                    n2--;
                }
                break;

                case 3:
                Environment.Exit(0);
                break; 

                default:
                Console.WriteLine("Essa opção é inválida.");
                break;
            }
            Console.WriteLine("Deseja continuar? [s/n]" ); 
            opcao= Console.ReadLine(); 
            opcao= opcao.ToLower();
        }   
    }
  }
}