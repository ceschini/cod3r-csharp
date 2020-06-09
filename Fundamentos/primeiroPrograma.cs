using System;

namespace curso_csharp.Fundamentos {
     class primeiroPrograma {
        public static void Executar () {
            System.Console.Write ("Primeiro "); // permanece msm linha
            System.Console.WriteLine ("Programa");
            // nao precisa System por causa do 'using System'
            Console.WriteLine ("Terminou!"); // escreve desce linha
        }
    }
}