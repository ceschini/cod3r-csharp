// O construtor de todas classes na hierarquia precisam ser
// chamados, terminando com o construtor base

using System;

namespace curso_csharp.OO
{
    public class Animal {
        public string Nome {get; set;}
        
        public Animal(string nome) {
            Nome = nome;
        }
    }

    public class Cachorro : Animal {
        public double Altura {get; set;}

        public Cachorro(string nome) : base(nome) {
            Console.WriteLine($"Cachorro {nome} inicializado");
        }
        // chama o construtor de cima, que chama o base, setando o nome
        //  e depois continuando no construtor abaixo
        public Cachorro(string nome, double altura) : this(nome) {
            Altura = altura;
        }

        public override string ToString() {
            return $"{Nome} tem {Altura}cm de altura";
        }
    }
    public class ConstrutorThis
    {
        public static void Executar() {
            var spike = new Cachorro("Spike");
            var max = new Cachorro("Max", 40.0);

            // Chama metodo toString automaticamente
            Console.WriteLine(spike);
            // Chamando método explicitamente
            Console.WriteLine(max.ToString());
        }
    }
}