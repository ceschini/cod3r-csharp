using System;
using System.Collections;

namespace curso_csharp.Colecoes
{
    public class ColecoesStack
    {
        public static void Executar() {
            // pilha = FILO
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            
            foreach (var item in pilha) {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}");

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nCount: {pilha.Count}");
            Console.WriteLine($"Peek: {pilha.Peek()}");
            Console.WriteLine($"Count: {pilha.Count}");
        }
    }
}