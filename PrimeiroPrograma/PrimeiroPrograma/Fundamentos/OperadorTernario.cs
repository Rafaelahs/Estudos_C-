using System;
using System.Collections.Generic;
using System.Text;

namespace UcursoCsharp.Fundamentos
{
    class OperadorTernario
    {
        public static void executar()
        {
            var nota = 7.0;
            bool bomComportamento = true;
            String resultado = nota >= 7.0 && bomComportamento ? "aprovado" : "repovado";
            Console.WriteLine(resultado);
        }
    }
}
