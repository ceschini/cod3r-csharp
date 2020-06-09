namespace curso_csharp.Fundamentos
{
    public class Conversoes
    {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro;
            System.Console.WriteLine(quebrado);
            
            double nota = 9.7;
            int notaTruncada = (int) nota;
            System.Console.WriteLine("Nota truncada: {0}", notaTruncada);

            System.Console.Write("Digite sua idade: ");
            string idadeString = System.Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            System.Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = System.Convert.ToInt32(idadeString);
            System.Console.WriteLine("Resultado: {0}", idadeInteiro);

            // Convertendo de forma segura
            System.Console.Write("Digite o primeiro número: ");
            string palavra = System.Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            System.Console.WriteLine("Resultado 1: {0}", numero);

            // Modo otimizado
            System.Console.Write("Digite o segundo número: ");
            int.TryParse(System.Console.ReadLine(), out int numero2);
            System.Console.WriteLine("Resultado 2: {0}", numero2);
        }
    }
}