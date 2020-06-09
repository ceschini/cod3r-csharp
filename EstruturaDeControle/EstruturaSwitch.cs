using System;

namespace curso_csharp.EstruturaDeControle
{
    public class EstruturaSwitch
    {
        public static void Executar() {
            System.Console.Write("Avalie meu atendimento (de 1 a 5): ");
            int.TryParse(Console.ReadLine(), out int nota);

            // sem break dá erro,
            // não pode passar de um case para outro

            switch (nota) {
                case 0:
                    Console.WriteLine("Sua nota foi:");
                    Console.WriteLine("Péssimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Sua nota foi:");
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Sua nota foi:");
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Sua nota foi:");
                    Console.WriteLine("Bom");
                    break;
                case 5: { // nao precisa do bloco mas pode ter
                    Console.WriteLine("Sua nota foi:");
                    Console.WriteLine("Ótimo");
                    break;
                }
                default:
                    Console.WriteLine("Nota inválida!");
                    break;
            }
            System.Console.WriteLine("Obrigado por responder");
        }
    }
}