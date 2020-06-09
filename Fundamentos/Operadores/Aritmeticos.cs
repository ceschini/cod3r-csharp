using System;

namespace curso_csharp.Fundamentos.Operadores
{
    public class Aritmeticos
    {
        public static void Executar() {
            // Preço Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - total * desconto;
            System.Console.WriteLine("Preço final: {0}", totalComDesconto);

            // IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2); //Pow = potencia
            System.Console.WriteLine($"IMC é {imc}."); // interpolacao!

            // Número Par/Impar
            int par = 42;
            int impar = 55;
            System.Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            System.Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}