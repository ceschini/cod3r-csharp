namespace curso_csharp.Fundamentos
{
    public class Inferencia
    {
        public static void Executar() {
            // C# viu as aspas duplas e inferiu como sendo string
            var nome = "Lucas";
            System.Console.WriteLine(nome);

            // não pode pq C# não vai inferir o tipo:
            // var idade;
            var idade = 24;
            System.Console.WriteLine(idade);
            
            // declaração
            int a;
            // inicialização
            a = 3;
            // declaração E inicialização
            int b = 2;
            System.Console.WriteLine(a + b);
        }
    }
}