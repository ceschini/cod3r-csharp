using System;

namespace curso_csharp.EstruturaDeControle
{
    public class EstruturaElseIf
    {
        public static void Executar() {
            System.Console.Write("Digite a nota do aluno: ");
            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 9.0) 
            {
                System.Console.WriteLine("Quadro de honra!");
            } 
            else if (nota >= 7.0) 
            {
                System.Console.WriteLine("Aprovado!");
            }
            else if(nota >= 5.0) 
            {
                System.Console.WriteLine("Recuperação!");
            }
            else
            {
                System.Console.WriteLine("Reprovado :c ");
            }
            
            System.Console.WriteLine("Fim");
        }
    }
}