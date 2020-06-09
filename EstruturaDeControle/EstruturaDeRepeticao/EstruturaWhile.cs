using System;

namespace curso_csharp.EstruturaDeControle.EstruturaDeRepeticao
{
    public class EstruturaWhile
    {
        public static void Executar() {
            int palpite = 0;
            Random random = new Random();

            // intervalo de 1 a 15
            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado) {
                Console.Write("Insira o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    // mudar cor da linha no console
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero encontrado em {0} tentativa(s).",
                     tentativas);
                    //  voltar para cor padrão
                    Console.BackgroundColor = corAnterior;
                } else if (palpite > numeroSecreto) {
                    Console.WriteLine("Menor... Tente novamente");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                } else {
                    Console.WriteLine("Maior... Tente novamente");
                    Console.WriteLine("Tentativas restantes: {0}", tentativasRestantes);
                }
            }
        }
    }
}