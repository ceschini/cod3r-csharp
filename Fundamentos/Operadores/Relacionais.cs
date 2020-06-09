using System;

namespace curso_csharp.Fundamentos.Operadores
{
    public class Relacionais
    {
        public static void Executar() {
            // double nota = 6.0;
            System.Console.Write("Digite uma nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;

            System.Console.WriteLine("Nota maior que total?: {0}", nota > 10.0);
            System.Console.WriteLine("Nota menor que total?: {0}", nota < 0.0);
            System.Console.WriteLine("Perfeito?: {0}", nota == 10.0);
            System.Console.WriteLine("Tem como melhorar?: {0}", nota != 10.0);
            System.Console.WriteLine("Passou por média?: {0}", nota >= notaDeCorte);
            System.Console.WriteLine("Recuperação?: {0}", nota < notaDeCorte);
            System.Console.WriteLine("Reprovado?: {0}", nota <= 3.0);
        }
    }
}