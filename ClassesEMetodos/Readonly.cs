using System;

namespace curso_csharp.ClassesEMetodos
{
    public class Cliente {
        public string Nome;
        // readonly:
        // Atributo somente leitura que nao pode ser atribuído
        // (exceto em construtor ou inicializador de variavel)
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataNascimento() {
            return String.Format("{0}/{1}/{2}", Nascimento.Day,
            Nascimento.Month, Nascimento.Year);
        }
    }

    public class Readonly
    {
        public static void Executar() {
            var novoCliente = new Cliente("Ana Silva",
             new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataNascimento());
        }
    }
}