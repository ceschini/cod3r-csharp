using System;
using System.Collections.Generic;

namespace curso_csharp.MetodosEFuncoes
{
    public class ExemploLambda
    {
        public static void Executar() {
            // Lambda: função anônima armazenada em variável
            // Action não tem retorno, mas pode ter params
            Action algoNoConsole = () => {
                Console.WriteLine("Lambda com C#!");
            };

            algoNoConsole();

            // Func tem retorno
            Func<int> jogarDado = () => {
                Random random = new Random();
                return random.Next(1,7);
            };

            Console.WriteLine(jogarDado());

            // Func<params, output>
            // um unico parametro, retorno implicito, sem '{' 'return' '}'
            Func<int, string> conversorHex = 
               numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) => 
                String.Format("{0:d2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(1,1,2019));
        }
    }
}