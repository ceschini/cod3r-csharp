using System;

namespace curso_csharp.ClassesEMetodos
{
    public class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero) {
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero) {
            numero = 0;
            numero = numero + 15;
        }

        public static void Executar() {
            int a = 3; // precisa inicializar
            // passa a referencia da variavel
            // sem isso seria feito só uma cópia e nao ia alterar a
            AlterarRef(ref a);
            Console.WriteLine(a);

            // int b; // nao faz sentido inicializar
            AlterarOut(out int b);
            Console.WriteLine(b);
        }
    }
}