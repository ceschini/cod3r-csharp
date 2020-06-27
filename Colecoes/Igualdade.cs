using System;


namespace curso_csharp.Colecoes
{
    public class Igualdade
    {
        public static void Executar() {
            var p1 = new Produto("Caneta", 1.89);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;
            // Comparando endereços de memória
            Console.WriteLine(p1 == p2);
            Console.WriteLine(p3 == p2);
            
            // Equals default compara endereço memória
            // Equals sobrecarregado de Produto compara valores
            Console.WriteLine(p1.Equals(p2));
        }
    }
}