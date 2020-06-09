namespace curso_csharp.Fundamentos
{
    public class VariaveisEConstantes
    {
        public static void Executar() {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415; num da

            double area = PI * raio * raio;
            System.Console.WriteLine(area);
            System.Console.WriteLine("Área é " + area);

            //** Tipos internos **

            bool estaChovendo = false;
            System.Console.WriteLine("Está chovendo " + estaChovendo);

            // Tipos Inteiros

            // 1 byte range positivo (signed)
            byte idade = 45;
            System.Console.WriteLine("Idade " + idade);

            // 1 byte double range (unsigned)
            //MinValue bota menor valor daquele tipo de dado
            sbyte saldoDeGols = sbyte.MinValue; 
            System.Console.WriteLine("Saldo de gols " + saldoDeGols);

            // MaxValue bota maior valor daquele tipo de dado
            short salario = short.MaxValue;
            System.Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue;
            System.Console.WriteLine("Menor valor do inteiro " + menorValorInt);

            // inteiro sem sinal (unsigned)
            // '_' facilita leitura mas n muda nada
            uint populacaoBrasileira = 207_600_000;
            System.Console.WriteLine("População Brasileira " + populacaoBrasileira);

            // long = 8 bytes
            long menorValorLong = long.MinValue;
            System.Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            System.Console.WriteLine("População Mundial " + populacaoMundial);

            // Tipos Reais
            // float = 4 bytes
            // pra ser do tipo float precisa ter um f no final
            // porque número com ponto flutuante é considerado double
            float precoComputador = 1299.99f;
            System.Console.WriteLine("Preço computador " + precoComputador);

            // double = 8bytes
            double valorDeMercadoDaApple = 1_000_000_000_000.00; 
            System.Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

            // maior tipo real
            decimal distanciaEntreEstrelas = decimal.MaxValue;
            System.Console.WriteLine("Distância entre estrelas " + distanciaEntreEstrelas);

            // Tipo palavras
            char letra = 'b';
            System.Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao inferno";
            System.Console.WriteLine(texto);
        }
    }
}