using System;

namespace curso_csharp.Fundamentos.Operadores
{
    public class Unarios
    {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            // inverte sinal
            System.Console.WriteLine(-valorNegativo);
            System.Console.WriteLine(!booleano);

            numero1++;
            System.Console.WriteLine(numero1);

            --numero1;
            System.Console.WriteLine(numero1);

            System.Console.WriteLine(numero1++ == --numero2);
            System.Console.WriteLine($"{numero1} {numero2}");
        }
    }
}