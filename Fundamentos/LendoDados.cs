using System.Globalization;

namespace curso_csharp.Fundamentos
{
    public class LendoDados
    {
        public static void Executar() {
            System.Console.Write("Qual é o seu nome? ");
            string nome = System.Console.ReadLine();

            System.Console.Write("Qual é a sua idade? ");
            // ReadLine() retorna texto, Parse transforma p/ num
            int idade = int.Parse(System.Console.ReadLine());

            System.Console.Write("Qual é o seu salario? ");
            double salario = double.Parse(System.Console.ReadLine(),
            CultureInfo.InvariantCulture);
            // InvariantCulture para ignorar config do SO
            // e usar . para separar casas decimais
            System.Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}