using System;

namespace curso_csharp.Fundamentos.Operadores
{
    public class Atribuicao
    {
        public static void Executar() {
            var num1 = 3;
            num1 = 7;
            num1 += 10; // num1 = num1 + 10
            num1 -= 3; // num1 = num1 - 3
            num1 *= 5; //num1 = num1 * 5
            num1 /= 2; //num1 = num1 / 2

            System.Console.WriteLine(num1);

            // Atribuição por cópia
            int a = 1;
            int b = a;

            a++; // a = a + 1
            b--; // b = b - 1

            System.Console.WriteLine($"{a} {b}");

            // Atribuição por referência
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";
            System.Console.WriteLine(c.nome);
        }
    }
}