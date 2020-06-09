using System;

namespace curso_csharp.EstruturaDeControle
{
    public class UsandoContinue
    {
        public static void Executar() {
            int intervalo = 50;
            Console.WriteLine("Numeros pares entre 1 e {0}!", intervalo);

            for (int i = 1; i <= intervalo; i++) {
                if (i % 2 == 1) {
                    continue; // pula a iteração atual
                }
                Console.Write(i + " ");
            }
        }
    }
}