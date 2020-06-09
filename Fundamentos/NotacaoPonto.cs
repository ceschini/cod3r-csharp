namespace curso_csharp.Fundamentos
{
    public class NotacaoPonto
    {
        public static void Executar() {
            var saudacao = "olá".ToUpper().Insert(3, " World!")
            .Replace("World!", "Mundo!");
            System.Console.WriteLine(saudacao);
            System.Console.WriteLine("Teste".Length);
            string valorImportante = null;
            // '?' -> atributo só será acessado ou método executado
            // se a variável não estiver vazia (null)
            System.Console.WriteLine(valorImportante?.Length);
        }
    }
}