using System;

namespace curso_csharp.ClassesEMetodos
{
    public class Pessoa
    {
        // Atributos
        public string Nome;
        public int Idade;

        // Métodos
        public string Apresentar() {
            if (Nome != null && Idade != 0) {
            return string.Format(
                $"Olá, me chamo {Nome} e tenho {Idade} anos.");
            } else {
                return "";
            }
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }

        public void Zerar() {
            Nome = "";
            Idade = 0;
        }
    }
}