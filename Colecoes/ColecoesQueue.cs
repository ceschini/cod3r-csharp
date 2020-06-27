using System;
using System.Collections;
using System.Collections.Generic;

namespace curso_csharp.Colecoes
{
    public class ColecoesQueue
    {
        public static void Executar() {
            // fila = FIFO
            // fila generica
            var fila = new Queue<string>();

            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            // Exibe o elemento na ponta da fila sem remover
            Console.WriteLine(fila.Peek());
            // atributo com numero de elementos
            Console.WriteLine(fila.Count);
            // Remover da lista e retornar elemento
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            // fila não generica
            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item"));
            Console.WriteLine(salada.Contains("Item"));
        }
    }
}