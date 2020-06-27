using System;
using System.Collections.Generic;

namespace curso_csharp.Colecoes
{
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        // sobrecarregando metodos Equals e GetHashCode para 
        //verificar se objetos possuem mesmos valores
        public override bool Equals(object obj) {
            Produto outroProduto = (Produto)obj;
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;
            return mesmoNome && mesmoPreco;
        }

        public override int GetHashCode() {
            return Nome.Length;
        }
    }
    public class ColecoesList
    {
        public static void Executar() {
            var livro = new Produto("Game of Thrones", 49.9);
            // Estrutura indexada, homogênea e dinâmica
            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("DVD Seinfeld", 39.9),
                new Produto("Poster", 10)
            };
            // Adicionando os elementos da lista combo à lista carrinho
            carrinho.AddRange(combo);
            Console.WriteLine("Número de elementos no carrinho: " + carrinho.Count);
            carrinho.RemoveAt(3); // poster removido

            foreach (var item in carrinho) {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($") {item.Nome} {item.Preco}");
            }
        }
    }
}