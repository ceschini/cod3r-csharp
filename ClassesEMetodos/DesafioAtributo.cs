using System;

namespace curso_csharp.ClassesEMetodos
{
    public class DesafioAtributo
    {
        int a = 10;

        public static void Executar() {
            // Acessar variavel 'a' dentro do método Executar
            DesafioAtributo desafio = new DesafioAtributo();
             Console.WriteLine(desafio.a);
        }
    }
}