using System;

namespace curso_csharp.ClassesEMetodos
{
    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        // Construtor
        // visibilidade nome(params)
        public Carro(string Modelo, string fabricante, int ano) {
            // atribuindo ao atributo da classe o parametro recebido
            this.Modelo = Modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
        
        // Construtor Padrão: 
        // quando nao tem nenhum construtor ou quando define o mesmo
        public Carro() {

        }
    }
    public class Construtores
    {
        public static void Executar() {
            var carro1 = new Carro(); // construtor padrao
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;
            System.Console.WriteLine(
                $"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");
            
            var carro2 = new Carro("Ka", "Ford", 2018);
            System.Console.WriteLine(
                $"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");
            
            var carro3 = new Carro() {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019
            };
            System.Console.WriteLine(
                $"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");
        }
    }
}