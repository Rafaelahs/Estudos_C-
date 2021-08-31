using System;
using System.Collections.Generic;
using System.Text;

namespace UcursoCsharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void executar()
        {
            var preco = 1000;
            var imposto = 335;
            var desconto = 0.1;

            double total = preco + imposto;
            var TotalCOmDesconto = total - (total * desconto);
            Console.WriteLine("o preço final é {0}",TotalCOmDesconto);

            //IMC

            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC é {imc}.");

            // numero par/impar

            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}",par,par%2);
            Console.WriteLine("{0}/2 tem resto{1}", impar,impar%2);



        }
    }
}
