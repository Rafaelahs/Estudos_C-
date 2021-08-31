using System;
using System.Collections.Generic;
using System.Text;

namespace UcursoCsharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void executar()
        {
            var executouTrabalho1 = true;
            var executouTravalho2 = false;

            bool comprouTv50 = executouTrabalho1 & executouTravalho2;
            Console.WriteLine("Comprou a Tv 50?{0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTravalho2;
            Console.WriteLine("comprou o sorvete?{0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTravalho2;
            Console.WriteLine("Comprou a TV 32? {0}",comprouSorvete);

            Console.WriteLine("Mais saudável? {0}",!comprouSorvete);
        }
    }
}