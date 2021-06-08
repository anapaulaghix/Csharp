using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0, r=0;
            string op= "s";
            while (op == "s")
            {
              Console.WriteLine("Verifica se o número informado é par ou impar");
              Console.Write("Informe um número:");  
              n= Convert.ToInt32(Console.ReadLine());
              if (r= n % 2 == 0)
              {
                  Console.WriteLine("O número informado é PAR!");
              }
              else
              {
                  Console.WriteLine("O número informado é IMPAR!");
              }
              Console.WriteLine("Deseja continuar? [s/n]");
              op= Console.ReadLine();
            }

        }

    }
}
