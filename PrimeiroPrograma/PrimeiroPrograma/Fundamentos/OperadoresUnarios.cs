﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UcursoCsharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void executar()
        {
            var valorNegativo = -5;
            var num1 = 2;
            var num2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);

            num1++;
            Console.WriteLine(num1);

            --num1;
            Console.WriteLine( num1 );

            Console.WriteLine(num1++ == --num2);
            Console.WriteLine($"{num1} , {num2}");

        }
    }
}
