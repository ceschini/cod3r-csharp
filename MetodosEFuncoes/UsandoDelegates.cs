using System;

namespace curso_csharp.MetodosEFuncoes
{
    public class UsandoDelegates
    {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double x, double y) {
            return x + y;
        }

        static void MeuImprimirSoma(double a, double b) {
            Console.WriteLine(a + b);
        }
        public static void Executar() {
            // Associando delegate à função existente
            // Precisa ter mesma assinatura
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2, 3.9));

            ImprimirSoma op2 = MeuImprimirSoma;
            op2(5.4, 8);

            // Associando Func e Action à funções existentes
            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(2.5, 3));

            Action<double,double> op4 = MeuImprimirSoma;
            op4(7.7, 23.4);
        }
    }
}