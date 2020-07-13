using System;

namespace curso_csharp.API
{
    public class ExemploDateTime
    {
        public static void Executar() {
            var dateTime = new DateTime(1996, 5, 25);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            // Sem horas

            var hoje = DateTime.Today;
            Console.WriteLine("Hoje é: " + hoje);

            // Com horas
            var atual = DateTime.Now;
            Console.WriteLine("Agora é: " + atual);
            Console.WriteLine("Hora: " + atual.Hour);
            Console.WriteLine("Minutos: " + atual.Minute);

            var amanha = atual.AddDays(1);
            Console.WriteLine("Amanhã: " + amanha);

            var ontem = atual.AddDays(-1);
            Console.WriteLine("Ontem: " + ontem);

            Console.WriteLine(atual.ToString("dd"));
            Console.WriteLine(atual.ToString("d"));
            Console.WriteLine(atual.ToString("D"));
            Console.WriteLine(atual.ToString("g"));
            Console.WriteLine(atual.ToString("G"));
            Console.WriteLine(atual.ToString("dd-MM-yyyy HH:mm"));
        }
    }
}