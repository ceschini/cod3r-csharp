using System;

namespace curso_csharp.ClassesEMetodos
{
    public class CalculadoraEstatica {
        // Métodos static não pertencem ao objeto, mas sim à classe
        // Método de Classe
        public static int Multiplicar(int a, int b) {
            return a * b;
        }

        // Método de Instância
        public int Somar(int a, int b) {
            return a + b;
        }
    }
    
    public class MetodosEstaticos
    {
        public static void Executar() {
            // static pertence a classe
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            // sem static pertence a instância
            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 2));
        }
    }
}