using System;
using System.Collections.Generic;
using System.Text;

namespace UcursoCsharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia
            double raio = 4.5;
            // const = n~so pode mudar o valor 
            const double PI = 3.14;
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo" + estaChovendo);

            //tipo numerico 
            // só aceita valor positivo
            byte idade = 45;
            Console.WriteLine("Idade" + idade);
        
            sbyte saldoDeGols = sbyte.MinValue; // minValue = mostra o valor minimo do byte
            Console.WriteLine("Saldo de gols: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Sálario" + salario);

            int menorValor = int.MinValue; // mais usado
            Console.WriteLine("Menor int" + menorValor);

            long MenorValorLong = long.MinValue; // long = numeros interos
            Console.WriteLine("Menor long" + MenorValorLong);

            float precoComputador = 1999.99f;

        }
    }
}
