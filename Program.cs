using System;
using System.Collections.Generic;
using curso_csharp.Fundamentos;
using curso_csharp.Fundamentos.Operadores;
using curso_csharp.EstruturaDeControle;
using curso_csharp.EstruturaDeControle.EstruturaDeRepeticao;
using curso_csharp.ClassesEMetodos;

namespace curso_csharp {
    class Program {
        static void Main (string[] args) {
            var central = new CentralDeExercicios (new Dictionary<string, Action> () { 
                // 1. Fundamentos
                { "Primeiro Programa - Fundamentos", primeiroPrograma.Executar },
                { "Comentários - Fundamentos", Comentarios.Executar},
                { "Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                { "Inferência - Fundamentos", Inferencia.Executar},
                { "Interpolação - Fundamentos", Interpolacao.Executar},
                { "Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                { "Lendo Dados - Fundamentos", LendoDados.Executar},
                { "Formatando Números - Fundamentos", FormatandoNumero.Executar},
                { "Conversões - Fundamentos", Conversoes.Executar},
                // 1.2 Operadores
                { "Operadores Aritméticos - Fundamentos", Aritmeticos.Executar},
                { "Operadores Relacionais - Fundamentos", Relacionais.Executar},
                { "Operadores Lógicos - Fundamentos", Logicos.Executar},
                { "Operadores de Atribuição - Fundamentos", Atribuicao.Executar},
                { "Operadores Unários - Fundamentos", Unarios.Executar},
                { "Operador Ternário - Fundamentos", Ternario.Executar},
                // 2. Estruturas de Controle
                { "Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                { "Estrutura If/Else - Estruturas de Controle", EstruturaIfElse.Executar},
                { "Estrutura Else If - Estruturas de Controle", EstruturaElseIf.Executar},
                { "Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                // 2.3 Estruturas de Repetição
                { "Estrutura While - Estruturas de Repetição", EstruturaWhile.Executar},
                { "Estrutura Do While - Estruturas de Repetição", EstruturaDoWhile.Executar},
                { "Estrutura For - Estruturas de Repetição", EstruturaFor.Executar},
                { "Estrutura Foreach - Estruturas de Repetição", EstruturaForEach.Executar},
                { "UsandoBreak - Estruturas de Controle", UsandoBreak.Executar},
                { "UsandoContinue - Estruturas de Controle", UsandoContinue.Executar},
                // 3 Classes e Métodos
                { "Membros - Classes e Métodos", Membros.Executar},
                { "Construtores - Classes e Métodos", Construtores.Executar},
                { "Métodos Com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
            });

            central.SelecionarEExecutar ();
        }
    }
}