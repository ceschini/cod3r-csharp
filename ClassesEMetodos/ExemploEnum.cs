using System;

namespace curso_csharp.ClassesEMetodos
{
    // Não se usa acento, mas usa PascalCase
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };

    public class Filme {
        public string Titulo;
        public Genero GeneroDoFilme;
    }

    public class ExemploEnum
    {
        public static void Executar() {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Sharknado 17";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;
            Console.WriteLine("{0} é {1}!", filmeParaFamilia.Titulo,
            filmeParaFamilia.GeneroDoFilme);
        }
    }
}