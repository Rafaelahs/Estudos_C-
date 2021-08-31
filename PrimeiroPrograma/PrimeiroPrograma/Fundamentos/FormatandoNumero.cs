using System;
using System.Globalization;

namespace UcursoCsharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void executar()
        {
            double valor = 15.157;
            Console.WriteLine(valor.ToString("F1")); //uma casa decimal
            Console.WriteLine(valor.ToString("C"));// colocar moeda local
            Console.WriteLine(valor.ToString("P")); // colocar porcentual
            Console.WriteLine(valor.ToString("#.##")); // duas casas decimais (opção)

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0", cultura));

            int inteiro = 254;
            Console.WriteLine(inteiro.ToString("D10"));// colocar zeros na frente
        }

    }
}
