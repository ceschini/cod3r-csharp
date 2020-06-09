using System;

namespace curso_csharp.Fundamentos.Operadores
{
    public class Logicos
    {
        public static void Executar() {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            // Operadores binários
            var comprouTv50 = executouTrabalho1 && executouTrabalho2; // AND
            System.Console.WriteLine("Comprou a TV 50?: {0}", comprouTv50);
 
            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2; //XOR
            System.Console.WriteLine("Comprou a TV 32?: {0}", comprouTv32);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2; // OR
            System.Console.WriteLine("Comprou sorvete?: {0}", comprouSorvete);

            // Operador unário
            System.Console.WriteLine("Mais saudável?: {0}", !comprouSorvete); //NOT
        }
    }
}