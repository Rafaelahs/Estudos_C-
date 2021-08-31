using System;
using System.Collections.Generic;
using System.Text;

namespace UcursoCsharp.EstruturaDeControle
{
    class EstruturaIfElse
    {
        public static void executar()
        {
            double nota = 7.0;

            if (nota>=7.0)
            {
                Console.WriteLine("Aprovado");
                Console.WriteLine("Não fez mais que sua obrigação...");
            }
            else
            {
                Console.WriteLine("Recuperação");
            }
        }
    }
}
