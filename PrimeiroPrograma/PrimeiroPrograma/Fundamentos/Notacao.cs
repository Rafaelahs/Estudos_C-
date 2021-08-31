using System;
using System.Collections.Generic;
using System.Text;

namespace UcursoCsharp.Fundamentos
{
    class Notacao
    {
        public static void executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, "word").Replace("word", "mundo");
            Console.WriteLine(saudacao);
        }
    }
}
