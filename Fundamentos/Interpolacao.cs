namespace curso_csharp.Fundamentos
{
    public class Interpolacao
    {
        public static void Executar() {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            System.Console.WriteLine("O " + nome + " da marca " + marca
             + " custa R$" + preco);
            //  Interpolação!
             System.Console.WriteLine("O {0} da marca {1} custa R${2}",
             nome, marca, preco);
             System.Console.WriteLine($"A marca {marca} é evil");
             System.Console.WriteLine($"1 + 1 = {1 + 1}");
        }
    }
}