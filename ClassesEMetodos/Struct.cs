using System;

namespace curso_csharp.ClassesEMetodos
{
    interface Ponto {
        void MoverNaDiagonal(int delta);
    }

    // struct suporta interfaces
    // struct Coordenada aderente a interface Ponto
    struct Coordenada: Ponto {
        public int X;
        public int Y;

        public Coordenada(int x, int y) {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta) {
            X += delta;
            Y += delta;
        }
    }

    public class ExemploStruct
    {
        public static void Executar() {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("Coordenada Inicial:");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("Y = {0}", coordenadaInicial.Y);

            var coordenadaFinal = new Coordenada(9, 1);
            coordenadaFinal.MoverNaDiagonal(10);
            Console.WriteLine("Coordenada Final:");
            Console.WriteLine("X = {0}", coordenadaFinal.X);
            Console.WriteLine("Y = {0}", coordenadaFinal.Y);
        }
    }
}