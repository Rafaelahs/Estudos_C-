using System;
using System.Collections.Generic;
using System.Text;

namespace UcursoCsharp.EstruturaDeControle
{
    class EstruturaWhile
    {
        public static void executar()
        {
            int chute = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while(tentativasRestantes >0 && !numeroEncontrado)
            {
                Console.WriteLine("Escreva seu chute: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out chute);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == chute)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Número encontrado em {0} tentativas",tentativas );
                    Console.BackgroundColor = corAnterior;

                }else if (chute > numeroSecreto)
                {
                    Console.WriteLine("Menor... Tente novamente");
                    Console.WriteLine("Número encontrado em {0} tentativas", tentativas);
                }
                else
                {
                    Console.WriteLine("maior... Tente novamente");
                    Console.WriteLine("Número encontrado em {0} tentativas", tentativas);
                }


            }


        }
    }
}
