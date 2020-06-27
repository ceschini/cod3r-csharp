using System;

namespace curso_csharp.ClassesEMetodos
{
    public class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano) {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }

        public static void Executar() {
            Formatar(mes: 5, dia: 25, ano: 1996);
        }
    }
}