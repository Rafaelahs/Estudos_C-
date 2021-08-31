using System;
using System.Collections.Generic;
using System.Text;

namespace UcursoCsharp.Fundamentos
{
    class Interpolacao
    {
        public static void executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            // Console.WriteLine("O " + nome + "da marca " + marca + " custa "+ preco + "."  ); // primeiro tipo
           // Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, preco); // 2 tipo
           // Console.WriteLine($"A marca {marca} é legal!");// 3 tipo
            Console.WriteLine($"1+1 =  { 1+1} !");
        }
    }
}
