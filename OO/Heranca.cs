using System;

namespace curso_csharp.OO
{
    public class Carro {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta) {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0) {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            } else {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        // virtual = método pode ser sobrescrito
        public virtual int Acelerar() {
            return AlterarVelocidade(5);
        }

        public int Frear() {
            return AlterarVelocidade(-5);
        }
    }
    
    // Uno herda de Carro
    public class Uno : Carro {
        // construtor de Uno chama construtor de Carro
        // passando VelocidadeMaxima (200)
        public Uno() :base(200) {
        }
    }

    public class Ferrari : Carro {
        public Ferrari() : base(350) {

        }

        // Sobrescrevendo método definido na classe pai
        public override int Acelerar() {
            return AlterarVelocidade(15);
        }

        // Oculta o método da classe Pai
        public new int Frear() {
            return AlterarVelocidade(-15);
        }
    }
    public class Heranca
    {
        public static void Executar() {
            Console.WriteLine("Uno");
            Uno carro1 = new Uno();
            Console.WriteLine("Acelerando, velocidade atual: " + carro1.Acelerar());
            Console.WriteLine("Acelerando, velocidade atual: " + carro1.Acelerar());
            Console.WriteLine("Freando, velocidade atual: " + carro1.Frear());
            Console.WriteLine("Freando, velocidade atual: " + carro1.Frear());
            Console.WriteLine("Freando, velocidade atual: " + carro1.Frear());

            Console.WriteLine("\nFerrari");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine("Acelerando, velocidade atual: " + carro2.Acelerar());
            Console.WriteLine("Acelerando, velocidade atual: " + carro2.Acelerar());
            Console.WriteLine("Freando, velocidade atual: " + carro2.Frear());

            // Tipo genérico recebendo tipo específico
            Console.WriteLine("\nFerrari com tipo Carro");
            Carro carro3 = new Ferrari();
            System.Console.WriteLine("Usando Acelerar() de Ferrari. Sobrescrita"); 
            Console.WriteLine("Acelerando, velocidade atual: " + carro3.Acelerar());
            Console.WriteLine("Acelerando, velocidade atual: " + carro3.Acelerar());
            System.Console.WriteLine("Usando Frear() de Carro. Ocultamento usa método do tipo");
            Console.WriteLine("Freando, velocidade atual: " + carro3.Frear());
            Console.WriteLine("Freando, velocidade atual: " + carro3.Frear());

            Console.WriteLine("\nFerrari tipo Carro virando Uno");
            carro3 = new Uno(); // Polimorfismo!
            Console.WriteLine("Acelerando, velocidade atual: " + carro3.Acelerar());
            Console.WriteLine("Acelerando, velocidade atual: " + carro3.Acelerar());
            Console.WriteLine("Freando, velocidade atual: " + carro3.Frear());
            Console.WriteLine("Freando, velocidade atual: " + carro3.Frear());

        }
    }
}