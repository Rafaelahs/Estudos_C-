using System;
using System.Collections.Generic;
using UcursoCsharp;
using UcursoCsharp.Fundamentos;
using UcursoCsharp.EstruturaDeControle;
using UcursoCsharp.ClassesEMetodos;

namespace PrimeiroPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>()
            {
                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiraPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Tipos de Inferência - fundamentos", Inferencia.executar},
                {"Interpolação - fundamentos", Interpolacao.executar},
                {"Notação Ponto - fundamentos", Notacao.executar},
                {"Lendo Dados do Console - Fundamentos", LendoDados.executar },
                { "Formatando Número - Fundamentos", FormatandoNumero.executar},
                {"Conversões - Fundamentos", Conversoes.Executar },
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.executar},
                {"Operadores Relacionais - Fundaemntos", OperadoresRelacionais.executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresDeAtribuição.executar },
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.executar},
                {"Operadores Ternarios - Fundamentos", OperadorTernario.executar},

                      //Estrutura De Controle

                {"Estrutura If - Estrutura De Controle", EstruturaIf.executar},
                {"Estrutura If/Else - Estrutura de Controle", EstruturaIfElse.executar},
                {"Estrutura If/Else/If - Estrutura de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura de Switch - Estrutura de Controle", EstruturaSwitch.executar},
                {"Estrutura While - Estrutura de Controle", EstruturaWhile.executar},
                {"Estrutura For - Estrutura de Controle", EstruturaFor.executar},
                {"Estrutura Foreach - Estrula de controle", EstrturaForEach.executar},

                      //Classes e Metodos

                {"Membros - Classes e Metodos", Membros.Executar}
            }); ;
            central.SelecionarEExecutar();
        }
       
    }
}
