using System;

namespace curso_csharp.ClassesEMetodos
{
    public class Membros
    {
        public static void Executar() {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Renato";
            sicrano.Idade = 37;

            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();
            // Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos");

            var fulano = new Pessoa(); // inferencia
            fulano.Nome = "Beto";
            fulano.Idade = 34;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}