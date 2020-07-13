using System;
using System.Collections.Generic;
using curso_csharp.Fundamentos;
using curso_csharp.Fundamentos.Operadores;
using curso_csharp.EstruturaDeControle;
using curso_csharp.EstruturaDeControle.EstruturaDeRepeticao;
using curso_csharp.ClassesEMetodos;
using curso_csharp.Colecoes;
using curso_csharp.OO;
using curso_csharp.MetodosEFuncoes;
using curso_csharp.Excecoes;
using curso_csharp.API;
using curso_csharp.TopicosAvancados;

namespace curso_csharp {
    class Program {
        // string[] args recebe os argumentos passados ao executar o programa no terminal
        // Ex: Program.cs -o Program -lX11
        // args[0] = -o, args[1] = Program, args[2] = lX11
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
                { "Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                { "Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                { "Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                { "Params - Classes e Métodos", Params.Executar},
                { "Parâmetros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                { "Getters & Setters - Classes e Métodos", GetSet.Executar},
                { "Propriedades - Classes e Métodos", Props.Executar},
                { "Atributos Readonly - Classes e Métodos", Readonly.Executar},
                { "Exemplo de Enum - Classes e Métodos", ExemploEnum.Executar},
                { "Struct - Classes e Métodos", ExemploStruct.Executar},
                { "Struct Vs Classe - Classes e Métodos", StructVsClasse.Executar},
                { "Valor Vs Referência - Classes e Métodos", ValorVsReferencia.Executar},
                { "Parâmetros por Referência - Classes e Métodos", ParametrosPorReferencia.Executar},
                { "Parâmetros com Valor Padrão - Classes e Métodos", ParametroPadrao.Executar},
                // Coleções
                { "Array - Coleções", Colecoes.Array.Executar},
                { "List - Coleções", ColecoesList.Executar},
                { "Array List - Coleções", ColecoesArrayList.Executar},
                { "Set - Coleções", ColecoesSet.Executar},
                { "Queue - Coleções", ColecoesQueue.Executar},
                { "Igualdade - Coleções", Igualdade.Executar},
                { "Stack - Coleções", ColecoesStack.Executar},
                { "Dictionary - Coleções", ColecoesDictionary.Executar},
                // Orientação a Objetos
                { "Herança - Orientação a Objetos", Heranca.Executar},
                { "Construtor This - Orientação a Objetos", ConstrutorThis.Executar},
                { "Encapsulamento - Orientação a Objetos", Encapsulamento.Executar},
                { "Polimorfismo - Orientação a Objetos", Polimorfismo.Executar},
                { "Abstract - Orientação a Objetos", Abstract.Executar},
                { "Interface - Orientação a Objetos", Interface.Executar},
                { "Sealed - Orientação a Objetos", Sealed.Executar},
                // Métodos e Funções
                { "Exemplo Lambda - Métodos & Funções", ExemploLambda.Executar},
                { "Lambdas Como Delegates - Métodos & Funções", LambdasDelegate.Executar},
                { "Usando Delegates - Métodos & Funções", UsandoDelegates.Executar},
                { "Delegates Como Função Anonima - Métodos & Funções", DelegateFuncAnonima.Executar},
                { "Delegates Como Parâmetros - Métodos & Funções", DelegatesComoParametro.Executar},
                { "Métodos de Extensão - Métodos & Funções", MetodosDeExtensao.Executar},
                // Exceções
                { "Primeira Exceção - Exceções", PrimeiraExcecao.Executar},
                { "Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},
                // Usando API
                { "Primeiro Arquivo - Usando API", PrimeiroArquivo.Executar},
                { "Lendo Arquivos - Usando API", LendoArquivos.Executar},
                { "Exemplo FileInfo - Usando API", ExemploFileInfo.Executar},
                { "Diretórios - Usando API", Diretorios.Executar},
                { "Exemplo DirectoryInfo - Usando API", ExemploDirectoryInfo.Executar},
                { "Exemplo Path - Usando API", ExemploPath.Executar},
                { "Exemplo DateTime - Usando API", ExemploDateTime.Executar},
                { "Exemplo TimeSpan - Usando API", ExemploTimeSpan.Executar},
                // Tópicos Avançados
                { "LINQ 1 - Tópicos Avançados", LINQ1.Executar},

            });

            central.SelecionarEExecutar ();
        }
    }
}