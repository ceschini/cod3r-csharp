using System;
using System.Collections.Generic;

namespace curso_csharp.Colecoes
{
    public class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);
            // Estrutura não indexada, que não aceita repetição
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("DVD Seinfeld", 39.9),
                new Produto("Poster", 10),
                // Permite duplicado devido falta do metodo GetHashCode
                // Não permite mais duplicado pois foi implementado GetHashCode
                new Produto("Poster", 10)
            };
            // Adicionando os elementos do set combo ao set carrinho
            carrinho.UnionWith(combo);
            Console.WriteLine("Número de elementos no carrinho: " + carrinho.Count);
            //carrinho.RemoveAt(3); set não tem indice

            foreach (var item in carrinho)
            {
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }
        }
    }
}