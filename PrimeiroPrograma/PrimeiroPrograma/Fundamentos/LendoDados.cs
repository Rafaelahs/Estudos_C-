using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace UcursoCsharp.Fundamentos
{
    class LendoDados
    {
        public static void executar()
        {
            Console.Write("Qual o seu nome?");
            string nome = Console.ReadLine();

            Console.Write("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é o seu sálario?");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture); // Usar o ponto como separador decimal

            Console.WriteLine($"Nome: {nome} idade: {idade} Sálario: R${salario} ");
        }
        
    }
}
