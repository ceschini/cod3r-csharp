using System.Globalization;

namespace curso_csharp.Fundamentos
{
    public class FormatandoNumero
    {
        public static void Executar() {
            double valor = 15.175;
            // formatar para 1 casa decimal, arredondando
            System.Console.WriteLine(valor.ToString("F1"));
            // C = moeda (SO inglês bota $ /  português R$)
            System.Console.WriteLine(valor.ToString("C"));
            // P = percentual
            System.Console.WriteLine(valor.ToString("P"));
            // duas casas decimais
            System.Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("pt-BR");
            // C0 = dinheiro sem casa decimal, na cultura informada
            System.Console.WriteLine(valor.ToString("C0", cultura));

            int inteiro = 256;
            // completa com 0 até 10 posições
            System.Console.WriteLine(inteiro.ToString("D3"));
        }
    }
}