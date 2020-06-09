namespace curso_csharp.EstruturaDeControle.EstruturaDeRepeticao
{
    public class EstruturaDoWhile
    {
        public static void Executar() {
            string entrada;

            do {
                System.Console.WriteLine("Qual o seu nome?");
                entrada = System.Console.ReadLine();
                
                System.Console.WriteLine("Seja bem-vindo {0}", entrada);
                System.Console.WriteLine("Deseja continuar? (s/n)");
                entrada = System.Console.ReadLine();
                
            } while (entrada.ToLower() == "s");
        }
    }
}