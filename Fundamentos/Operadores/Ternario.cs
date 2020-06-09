using System;

namespace curso_csharp.Fundamentos.Operadores
{
    public class Ternario
    {
        public static void Executar() {
            var nota = 9.0;
            bool bomComportamento = false;
            // expressao ? true : false
            string resultado = nota >= 7.0  && bomComportamento ?
             "Aprovado" : "Reprovado";
            System.Console.WriteLine(resultado);
        }
    }
}