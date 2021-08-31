using System;
using System.Collections.Generic;
using System.Text;

namespace UcursoCsharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            double nota = 9.7;
            int notatruncada = (int)nota;
            Console.WriteLine("Nota truncada: {0}", notatruncada);

            Console.WriteLine("digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("idadeInteiro inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado {0}", idadeInteiro);

            Console.WriteLine("Digite  o primeiro numero: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("Resultado 1: {0}", numero1);

            Console.WriteLine("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado numero 2 {0}", numero2);
        }
    }
}
