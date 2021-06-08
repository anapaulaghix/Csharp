using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, nmenor, nmaior;
            Console.Write("Digite um número: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            n2 = int.Parse(Console.ReadLine()); 
            
            if (n1 > n2){
                nmaior = n1;
                nmenor = n2;
            }else{
                nmaior = n2;
                nmenor = n1;
            }
            while (nmaior >= nmenor)
            {
                if (nmaior % 2 != 0)
                {
                    Console.WriteLine(nmaior);
                }
               nmaior--;
        }

    }
}
