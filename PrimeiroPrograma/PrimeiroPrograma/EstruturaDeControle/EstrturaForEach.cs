using System;
using System.Collections.Generic;
using System.Text;

namespace UcursoCsharp.EstruturaDeControle
{
    class EstrturaForEach
    {
        public static void executar()
        {
            var palavra = "opa";

            foreach(var letra in palavra)
            {
                Console.WriteLine(letra);
            }
        }
    }
}
