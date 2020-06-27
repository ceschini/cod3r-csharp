using System;

namespace curso_csharp.ClassesEMetodos
{
    public class Produto {
        // Atributos
        public string Nome; // instancia
        public double Preco; // instancia
        public static double Desconto = 0.1; // classe
        
        // Construtores 
        public Produto(string nome, double preco, double desconto) {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto() {

        }

        // Métodos
        public double CalcularDesconto() {
            return Preco - Preco * Desconto;
        }
    }
    public class AtributosEstaticos
    {
        public static void Executar() {
            var produto1 = new Produto("Caneta", 3.2, 0.1);

            var produto2 = new Produto() {
                Nome = "Borracha",
                Preco = 5.3,
            };

            // Atributo static, aplica a todas as instancias
            Produto.Desconto = 0.5;

            Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine($"Preço com desconto: {produto2.CalcularDesconto()}");

            Produto.Desconto = 0.02;

            Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine($"Preço com desconto: {produto2.CalcularDesconto()}");
        }
    }
}