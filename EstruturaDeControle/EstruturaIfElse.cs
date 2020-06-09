using System;

namespace curso_csharp.EstruturaDeControle
{
    public class EstruturaIfElse
    {
        public static void Executar() {
            double nota = 7.0;

            if (nota >= 7.0) {
                System.Console.WriteLine("Aprovado!");
            } else {
                System.Console.WriteLine("Recuperação");
            }
        }
    }
}